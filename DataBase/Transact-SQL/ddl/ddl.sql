/* File History
 * --------------------------------------------------------------------
 * Created by : Luciana PachecO
 * Date       : 11/05/2021
 * Purpose    : Criação da ddl.sql do projeto
 * --------------------------------------------------------------------
 */

 CREATE DATABASE divulga_tudo


SET ANSI_NULLS ON /* comportamento dos operadores de comparação */
SET QUOTED_IDENTIFIER ON /* delimitam identificadores e cadeias de caracteres */
SET ANSI_PADDING ON /* Controla como a coluna armazena valores menores que o tamanho definido da coluna */


IF EXISTS (SELECT TOP 1 [id] FROM dbo.sysobjects WHERE id = object_id(N'[anuncio]') AND OBJECTPROPERTY(id, N'IsTable') = 1)
  DROP TABLE [anuncio] ;
GO
CREATE TABLE [anuncio] (
[id] NUMERIC NOT NULL PRIMARY KEY IDENTITY(1,1),
[cliente] VARCHAR(255) not null ,
[nome_anuncio] VARCHAR(255),
[data_inicio] DATETIME,
[data_termino] DATETIME,
[investimento_dia] FLOAT,
[quantidade_maxima_visualizacao] NUMERIC,
[quantidade_maxima_cliques] NUMERIC,
[quantidade_maxima_compartilhamento] NUMERIC
);

GO

--
