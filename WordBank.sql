CREATE TABLE [dbo].WordBank
(
   word VARCHAR (100) NOT NULL PRIMARY KEY,
   phonetics VARCHAR(100),
   w_type VARCHAR(100),
   w_level VARCHAR(100) NULL,
   meaning VARCHAR(500) NULL,
   collocations VARCHAR(500) NULL,
   intentence VARCHAR(500) NULL,
   synonym_s VARCHAR(500)
)
