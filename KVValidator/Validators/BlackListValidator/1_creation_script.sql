-- skript na vytvorenie tabuliek pre zoznamy subjektov

-- hlavna tabulka
DROP TABLE IF EXISTS T_BLACKLIST;
CREATE TABLE T_BLACKLIST (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT,
	"IC_DPH" TEXT,
	"NAZOV" TEXT,
	"OBEC" TEXT,
	"PSC" TEXT,
	"ADRESA" TEXT,
	"ROK_PORUSENIA" INTEGER,
	"DAT_ZVEREJNENIA" TEXT,
	"COMMENT" TEXT,
	"VALID" INTEGER DEFAULT 1
);