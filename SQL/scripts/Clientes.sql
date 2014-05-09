select * from (
SELECT [Publ_Cli_Dni]
      ,[Publ_Cli_Apeliido]
      ,[Publ_Cli_Nombre]
      ,[Publ_Cli_Fecha_Nac]
      ,[Publ_Cli_Mail]
      ,[Publ_Cli_Dom_Calle]
      ,[Publ_Cli_Nro_Calle]
      ,[Publ_Cli_Piso]
      ,[Publ_Cli_Depto]
      ,[Publ_Cli_Cod_Postal]
FROM [GD1C2014].[gd_esquema].[Maestra]
  where Publ_Cli_Dni is not null
)
union all 

--select * from (
(
SELECT [Cli_Dni]
      ,[Cli_Apeliido]
      ,[Cli_Nombre]
      ,[Cli_Fecha_Nac]
      ,[Cli_Mail]
      ,[Cli_Dom_Calle]
      ,[Cli_Nro_Calle]
      ,[Cli_Piso]
      ,[Cli_Depto]
      ,[Cli_Cod_Postal] 
  FROM [GD1C2014].[gd_esquema].[Maestra]
  where Cli_Dni is not null
 )