/* File History
--------------------------------------------------------------------
Created by : Luciana Pacheco
Date       : 11/05/2021
Purpose    : procedimentos para manipulação dos dados de anúncios
--------------------------------------------------------------------
Updated by :
Date       :
Purpose    :
--------------------------------------------------------------------
Updated by : 
Date       :
Purpose    :
--------------------------------------------------------------------
*/

IF EXISTS (SELECT TOP 1 [id] FROM dbo.sysobjects WHERE id = object_id(N'[stp_anuncio_pesquisar]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
  DROP PROCEDURE [stp_anuncio_pesquisar];
GO

CREATE PROCEDURE [stp_anuncio_pesquisar]
@cliente VARCHAR(255) = null,
@data_inicio DATE = null,
@data_termino DATE = null

WITH ENCRYPTION AS

SELECT @data_inicio = CONVERT(DATE,@data_inicio);
SELECT @data_termino = CONVERT(DATE,@data_termino);


IF @data_termino IS NOT NULL AND @data_inicio IS NOT NULL
  SELECT * FROM [view_anuncio] WHERE data_termino = @data_termino and data_inicio = @data_inicio

ELSE IF @cliente IS NOT NULL AND @data_termino IS NOT NULL
  SELECT * FROM [view_anuncio] WHERE data_termino = @data_termino and cliente like '%'+@cliente+'%'

ELSE IF @cliente IS NOT NULL AND @data_inicio IS NOT NULL
  SELECT * FROM [view_anuncio] WHERE data_inicio = @data_inicio and cliente like '%'+@cliente+'%'

ELSE IF @data_inicio IS NOT NULL
  SELECT * FROM [view_anuncio] WHERE data_inicio = @data_inicio

ELSE IF @data_termino IS NOT NULL
  SELECT * FROM [view_anuncio] WHERE data_termino = @data_termino

ELSE IF @cliente IS NOT NULL 
  SELECT * FROM view_anuncio WHERE  cliente like '%'+@cliente+'%'

ELSE
  SELECT * FROM [view_anuncio]

GO

--

IF EXISTS (SELECT TOP 1 [id] FROM dbo.sysobjects WHERE id = object_id(N'[stp_anuncio_incluir]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
  DROP PROCEDURE [stp_anuncio_incluir];
GO

CREATE PROCEDURE [stp_anuncio_incluir]
@cliente VARCHAR(255),
@nome_anuncio VARCHAR(255),
@data_inicio DATE,
@data_termino DATE,
@investimento_dia FLOAT,
@quantidade_maxima_visualizacao NUMERIC,
@quantidade_maxima_cliques NUMERIC,
@quantidade_maxima_compartilhamento NUMERIC

WITH ENCRYPTION AS

INSERT INTO anuncio (cliente, nome_anuncio, data_inicio, data_termino, investimento_dia, quantidade_maxima_visualizacao, quantidade_maxima_cliques, quantidade_maxima_compartilhamento) 
             values (@cliente, @nome_anuncio, @data_inicio, @data_termino, @investimento_dia, @quantidade_maxima_visualizacao, @quantidade_maxima_cliques, @quantidade_maxima_compartilhamento)
   
GO 


IF EXISTS (SELECT TOP 1 [id] FROM dbo.sysobjects WHERE id = object_id(N'[stp_anuncio_excluir]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
  DROP PROCEDURE [stp_anuncio_excluir];
GO

CREATE PROCEDURE [stp_anuncio_excluir]
@id INT
WITH ENCRYPTION AS

  DELETE FROM anuncio where id = @id
GO

-- 

IF EXISTS (SELECT TOP 1 [id] FROM dbo.sysobjects WHERE id = object_id(N'[stp_anuncio_alterar]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
  DROP PROCEDURE stp_anuncio_alterar;
GO

CREATE PROCEDURE stp_anuncio_alterar
@id INT,
@cliente VARCHAR(255),
@nome_anuncio VARCHAR(255),
@data_inicio DATE,
@data_termino DATE,
@investimento_dia FLOAT,
@quantidade_maxima_visualizacao NUMERIC,
@quantidade_maxima_cliques NUMERIC,
@quantidade_maxima_compartilhamento NUMERIC
WITH ENCRYPTION AS

UPDATE  anuncio SET 
[cliente] = @cliente,
[nome_anuncio] = @nome_anuncio, 
[data_inicio] = @data_inicio,
[data_termino] = @data_termino,
[investimento_dia] = @investimento_dia,
[quantidade_maxima_visualizacao] = @quantidade_maxima_visualizacao, 
[quantidade_maxima_cliques] = @quantidade_maxima_cliques,
[quantidade_maxima_compartilhamento] = @quantidade_maxima_compartilhamento
WHERE [id] = @id
   
GO

--

