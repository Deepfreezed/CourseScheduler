﻿CREATE TABLE [dbo].[STUDENT](
STUD_NUM NVARCHAR(10) NOT NULL  
, DEPT_NUM NVARCHAR(10) 
, LNAME NVARCHAR(25) 
, FNAME NVARCHAR(25) 
, STREET NVARCHAR(60) 
, CITY NVARCHAR(25) 
, STATE NVARCHAR(10) 
, EMAIL NVARCHAR(200)  
, GENDER CHAR(2) 
, DOB DATE 
, CONSTRAINT STUDENT_PK PRIMARY KEY (STUD_NUM)
, CONSTRAINT STUDENT_DEPTNUM_FK FOREIGN KEY (DEPT_NUM) REFERENCES DEPARTMENT(DEPT_NUM));