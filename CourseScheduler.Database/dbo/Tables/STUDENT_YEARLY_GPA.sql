﻿CREATE TABLE [dbo].[STUDENT_YEARLY_GPA](
STUD_NUM NVARCHAR(10) NOT NULL
, YEAR NVARCHAR (10) NOT NULL
, TERM NVARCHAR (10) NOT NULL
, GPA NUMERIC(2, 1)
, CONSTRAINT STUDENT_GPA_PK PRIMARY KEY (STUD_NUM, YEAR, TERM)
, CONSTRAINT STUDENT_GPA_FK FOREIGN KEY (STUD_NUM) REFERENCES STUDENT (STUD_NUM));