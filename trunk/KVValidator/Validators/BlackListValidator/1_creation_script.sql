-- skript na vytvorenie tabuliek pre zoznamy subjektov

-- hlavna tabulka
DROP TABLE IF EXISTS T_BLACKLIST;
CREATE TABLE T_BLACKLIST (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT,
	-- TODO
	"COMMENT" TEXT,
	"VALID" INTEGER DEFAULT 1
);
