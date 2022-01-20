using System.Collections.Generic;
using System.Threading.Tasks;
using Geres4U.Data.DataModels;

namespace Geres4U.Data
{
    public class PointOfInterestData : IPointOfInterestData
    {
        private readonly IDataAccess _db;

        public PointOfInterestData(IDataAccess db)
        {
            _db = db;
        }

        public Task<List<PointOfInterestDataModel>> GetPointsOfInterest()
        {
            string sql = @"SELECT (ID, Name, Images, Lat, Long, isSugestion, Description) FROM geres4udb.PointOfInterest 
                         WHERE isSugestion = false
                         ORDER BY ID DESC";
            return _db.LoadData<PointOfInterestDataModel, dynamic>(sql, new { });
        }

        public Task<List<PointOfInterestDataModel>> getSugestionsPointsOfInterest()
        {
            string sql = @"SELECT (ID, Name, Images, Lat, Long, isSugestion, Description) FROM geres4udb.PointOfInterest 
                         WHERE isSugestion = true
                         ORDER BY ID DESC";
            return _db.LoadData<PointOfInterestDataModel, dynamic>(sql, new { });
        }

        public Task<List<PointOfInterestDataModel>> getPointOfInterest(PointOfInterestDataModel p)
        {
            string sql = @"SELECT * FROM geres4udb.PointOfInterest WHERE ID = @id";
            return _db.LoadData<PointOfInterestDataModel, dynamic>(sql, p);
        }

        public Task InsertPointOfInterestWithoutDescriptionAndImage(PointOfInterestDataModel pointOfInterest)
        {
            string sql = @"IF NOT EXISTS (SELECT * FROM geres4udb.PointOfInterest WHERE ID = @ID)
                            BEGIN
                            INSERT INTO geres4udb.PointOfInterest(ID, Name, Images, Lat, Long, isSugestion, Description)
                            VALUES (@ID, @Name, NULL, @Lat, @Long, false, NULL)
                            END";
            return _db.SaveData(sql, pointOfInterest);
        }

        public Task InsertPointOfInterestWithDescriptionWithoutImage(PointOfInterestDataModel pointOfInterest)
        {
            string sql = @"IF NOT EXISTS (SELECT * FROM dbo.PointOfInterest WHERE ID = @ID)
                            BEGIN
                            INSERT INTO dbo.PointOfInterest(ID, Name, Images, Lat, Long, isSugestion, Description)
                            VALUES (@ID, @Name, NULL, @Lat, @Long, false, @Description)
                            END";
            return _db.SaveData(sql, pointOfInterest);
        }

        public Task InsertPointOfInterestWithDescriptionAndImagePath(PointOfInterestDataModel pointOfInterest)
        {
            string sql = @"IF NOT EXISTS (SELECT * FROM dbo.PointOfInterest WHERE ID = @ID)
                            BEGIN
                            INSERT INTO dbo.PointOfInterest(ID, Name, Images, Lat, Long, isSugestion, Description)
                            VALUES (@ID, @Name, @Images, @Lat, @Long, false, @Description)
                            END";
            return _db.SaveData(sql, pointOfInterest);
        }

        // Nunca poderá adicionar sugestões c imagens visto que a imagem é o local path
        public Task InsertPointOfInterestSugestionWithoutDescription(PointOfInterestDataModel pointOfInterest)
        {
            string sql = @"IF NOT EXISTS (SELECT * FROM dbo.PointOfInterest WHERE ID = @ID)
                            BEGIN
                            INSERT INTO dbo.PointOfInterest(ID, Name, Images, Lat, Long, isSugestion, Description)
                            VALUES (@ID, @Name, NULL, @Lat, @Long, true, NULL)
                            END";
            return _db.SaveData(sql, pointOfInterest);
        }

        public Task InsertPointOfInterestSugestion(PointOfInterestDataModel pointOfInterest)
        {
            string sql = @"IF NOT EXISTS (SELECT * FROM dbo.PointOfInterest WHERE ID = @ID)
                            BEGIN
                            INSERT INTO dbo.PointOfInterest(ID, Name, Images, Lat, Long, isSugestion, Description)
                            VALUES (@ID, @Name, NULL, @Lat, @Long, true, @Description)
                            END";
            return _db.SaveData(sql, pointOfInterest);
        }

        public Task UpdatePointOfInterest(PointOfInterestDataModel pointOfInterest)
        {
            string sql =
                @"UPDATE dbo.PointOfInterest SET Name = @Name, Images = @Images, Lat = @Lat, Long = @Long, isSugestion = @isSugestion, Description = @Description
                           WHERE ID = @ID";
            return _db.SaveData(sql, pointOfInterest);
        }

        public Task RemovePointOfInterest(PointOfInterestDataModel pointOfInterest)
        {
            string sql = @"DELETE FROM dbo.PointOfInterest
                           WHERE ID = @ID";
            return _db.SaveData(sql, pointOfInterest);
        }

        public Task acceptPointOfInterestSugestion(PointOfInterestDataModel pointOfInterest)
        { 
            PointOfInterestDataModel p = new PointOfInterestDataModel(pointOfInterest.ID, pointOfInterest.Name,
                    pointOfInterest.Images, pointOfInterest.Lat, pointOfInterest.Long, false,
                    pointOfInterest.Description);
            return UpdatePointOfInterest(p);
        }
    }
}
