create table WordsList(
   word VARCHAR (100) NOT NULL,
   phonetics VARCHAR(100),
   w_level VARCHAR(100) NOT NULL,
   meaning VARCHAR(500) NOT NULL,
   collocations VARCHAR(500) NOT NULL,
   intentence VARCHAR(500) NOT NULL,
   synonym_s VARCHAR(500),
   PRIMARY KEY(word)
);
