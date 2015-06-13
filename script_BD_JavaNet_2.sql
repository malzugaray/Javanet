USE [BD_JavaNet]
GO

CREATE TABLE [dbo].[t_cliente](
	[codCliente] [int] NOT NULL,
	[razonSocialCliente] [nvarchar](50) NOT NULL,
	[rucCliente] [nvarchar](50) NOT NULL,
	[correo] [nvarchar](50) NOT NULL,
	[estado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_t_cliente] PRIMARY KEY CLUSTERED 
(
	[codCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[t_proyecto](
	[codProyecto] [int] NOT NULL,
	[nombreProyecto] [nvarchar](50) NOT NULL,
	[codCliente] [int] NOT NULL,
	[estado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_t_proyecto] PRIMARY KEY CLUSTERED 
(
	[codProyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[t_proyecto]  WITH CHECK ADD  CONSTRAINT [FK_t_proyecto_t_cliente] FOREIGN KEY([codCliente])
REFERENCES [dbo].[t_cliente] ([codCliente])
GO

ALTER TABLE [dbo].[t_proyecto] CHECK CONSTRAINT [FK_t_proyecto_t_cliente]
GO



CREATE TABLE [dbo].[t_solicitud](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[codProyecto] [int] NOT NULL,
	[estado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_t_solicitud] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[t_solicitud]  WITH CHECK ADD  CONSTRAINT [FK_t_solicitud_t_proyecto] FOREIGN KEY([codProyecto])
REFERENCES [dbo].[t_proyecto] ([codProyecto])
GO

ALTER TABLE [dbo].[t_solicitud] CHECK CONSTRAINT [FK_t_solicitud_t_proyecto]
GO

CREATE TABLE [dbo].[t_solicitud_detalle](
	[id] [int]IDENTITY(1,1) NOT NULL,
	[codigo] [int] NOT NULL,
	[cantidadColabor] [int] NOT NULL,
	[codPerfil] [nvarchar](50) NOT NULL,
	[codTecnologia] [nvarchar](50) NOT NULL,
	[codExperienciaRubro] [nvarchar](50) NOT NULL,
	[comentario] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[t_solicitud_detalle]  WITH CHECK ADD  CONSTRAINT [FK_t_solicitud_detalle_t_solicitud] FOREIGN KEY([codigo])
REFERENCES [dbo].[t_solicitud] ([codigo])
GO

ALTER TABLE [dbo].[t_solicitud_detalle] CHECK CONSTRAINT [FK_t_solicitud_detalle_t_solicitud]
GO

INSERT INTO [dbo].[t_cliente]
           ([codCliente]
           ,[razonSocialCliente]
           ,[rucCliente]
           ,[correo]
           ,[estado])
     VALUES
           (100
           ,'BANCO DE LA NACION'
           ,'20100040595'
           ,'bconacion@correo.com'
           ,'ACTIVO');
GO
INSERT INTO [dbo].[t_cliente]
           ([codCliente]
           ,[razonSocialCliente]
           ,[rucCliente]
           ,[correo]
           ,[estado])
     VALUES
           (101
           ,'MINERA SANTA ROSA'
           ,'20114578100'
           ,'starosa@correo.com'
           ,'ACTIVO');
GO
INSERT INTO [dbo].[t_cliente]
           ([codCliente]
           ,[razonSocialCliente]
           ,[rucCliente]
           ,[correo]
           ,[estado])
     VALUES
           (102
           ,'INDECOPI'
           ,'21526341587'
           ,'indecopi@correo.com'
           ,'INACTIVO');
GO
INSERT INTO [dbo].[t_proyecto]
           ([codProyecto]
           ,[nombreProyecto]
           ,[codCliente]
           ,[estado])
     VALUES
           (200
           ,'NUEVO CORE BANCARIO'
           ,100
           ,'ACTIVO')
GO
INSERT INTO [dbo].[t_proyecto]
           ([codProyecto]
           ,[nombreProyecto]
           ,[codCliente]
           ,[estado])
     VALUES
           (201
           ,'SISTEMA EN ATENCION EN VENTANILLA'
           ,100
           ,'INACTIVO')
GO






