﻿CREATE TABLE [dbo].[SUB_PROGRAM_IDENTIFIER]
(
	SUB_PROG_ID NVARCHAR(20) NOT NULL,
	NAME NVARCHAR(50) NOT NULL,
	COMMON_NAME NVARCHAR(100),
	CONSTRAINT SUB_PROG_IDEN_PK PRIMARY KEY (SUB_PROG_ID)
)