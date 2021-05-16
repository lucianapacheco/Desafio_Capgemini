
/* File History
--------------------------------------------------------------------
Created by : Luciana Pacheco
Date       : 11/05/2021
Purpose    : Criação da view de anúncio
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



--
IF EXISTS (SELECT TOP 1 [id] FROM dbo.sysobjects WHERE id = object_id(N'[view_anuncio]') AND OBJECTPROPERTY(id, N'Isview') = 1)
  DROP VIEW [view_anuncio];
GO

CREATE VIEW [view_anuncio] AS
  SELECT A.* FROM anuncio AS A 

GO
