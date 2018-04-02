using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DevAngular.Data.Entities;
using Oracle.ManagedDataAccess.Client;

namespace DevAngular.Data.Repositories
{
    public class CarRepository : BaseRepository , ICarRepository
    {
        public bool CreateCar(Car car)
        {
            try
            {
                var param = new OracleDynamicParameters();

                param.Add(
                    "p_COLOR", 
                    dbType: OracleDbType.Varchar2, 
                    direction: ParameterDirection.Input, 
                    size: car.Color.Length, 
                    value: car.Color
                );

                param.Add(
                    "p_MARCA", 
                    dbType: OracleDbType.Varchar2, 
                    direction: ParameterDirection.Input, 
                    size: car.Brand.Length,
                    value: car.Brand
                );

                param.Add(
                    "p_MODELO",
                    dbType: OracleDbType.Varchar2,
                    direction: ParameterDirection.Input,
                    size: car.Model.Length,
                    value: car.Model
                );


                //Ejecución del stored procedure
                SqlMapper.Execute(
                    connnection, 
                    "ACSELSEP.AUTOMOVIL_tapi.ins", 
                    param, 
                    commandType: CommandType.StoredProcedure
                );

                return true;
            }
            catch (OracleException ex)
            {
                throw ex;
            }        
        }

        public bool UpdateCar(Car car, int id)
        {
            try
            {
                var param = new OracleDynamicParameters();

                param.Add(
                    "p_COLOR", 
                    dbType: OracleDbType.Varchar2, 
                    direction: ParameterDirection.Input, 
                    size: car.Color.Length, 
                    value: car.Color
                );

                param.Add(
                    "p_MARCA", 
                    dbType: OracleDbType.Varchar2, 
                    direction: ParameterDirection.Input,
                    size: car.Brand.Length,
                    value: car.Brand
                );

                param.Add(
                    "p_MODELO",
                    dbType: OracleDbType.Varchar2,
                    direction: ParameterDirection.Input,
                    size: car.Model.Length,
                    value: car.Model
                );

                param.Add(
                    "p_ID",
                    dbType: OracleDbType.Int32,
                    direction: ParameterDirection.Input,
                    value: id
                );
                
                //Ejecución del stored procedure
                SqlMapper.Execute(
                    connnection, 
                    "ACSELSEP.AUTOMOVIL_tapi.upd", 
                    param, 
                    commandType: CommandType.StoredProcedure
                );

                return true;
            }
            catch (OracleException ex)
            {
                throw ex;
            }        
        }

        public bool DeleteCar(int id)
        {
            try
            {
                var param = new OracleDynamicParameters();

                param.Add(
                    "p_ID",
                    dbType: OracleDbType.Int32,
                    direction: ParameterDirection.Input,
                    value: id
                );

                //Ejecución del stored procedure
                SqlMapper.Execute(
                    connnection, 
                    "ACSELSEP.AUTOMOVIL_tapi.del", 
                    param, 
                    commandType: CommandType.StoredProcedure
                );

                return true;
            }
            catch (OracleException ex)
            {
                throw ex;
            }     
        }

        public IList<Car> GetCars()
        {
            try
            {
                var param = new OracleDynamicParameters();

                param.Add(
                    "sCurAutos", 
                    dbType: OracleDbType.RefCursor, 
                    direction: ParameterDirection.Output
                );
                
                IList <Car> cars = SqlMapper.Query<Car>(
                    connnection, 
                    "ACSELSEP.AUTOMOVIL_tapi.consulta", 
                    param, 
                    commandType: CommandType.StoredProcedure).ToList();
                
                return cars;
            }
            catch (OracleException ex)
            {
                throw ex;
            }
        }
    }
}
