--SET IDENTITY_INSERT [dbo].[DEPARTMENT] ON
--GO

MERGE INTO [dbo].[DEPARTMENT] AS TARGET
USING (VALUES
	('d01','Information Technology'),
	('d03','Mathematics and Statistics'),
	('d02','English'),
	('d05','Nursing'),
	('d18','Economics'),
	('d20','Speech, Hearing and Rehabilitation Services'),
	('d07','Management'),
	('d09','Art'),
	('d21','Music'),
	('d13','Philosophy'),
	('d15','Accounting'),
	('d16','Anthropology'),
	('d14','Theatre'),
	('d12','Modern Languages'),
	('d19','Geography'),
	('d04','Business Law'),
	('d08','Marketing'),
	('d24','Physics'),
	('d25','Technical Communication'),
	('d26','Biology'),
	('d27','Chemistry'),
	('d28','Astronomy'),
	('d29','Automotive Engineering Technology'),
	('d30','Aviation Management'),
	('d31','Business Administration'),
	('d32','Communications Disorders'),
	('d33','Computer Science'),
	('d34','Corporate and Community Fitness Minor'),
	('d35','Dance'),
	('d36','Earth Science'),
	('d37','Environmental Sciences'),
	('d38','Computer Information Science'),
	('d39','Computer Technology'),
	('d40','International Business'),
	('d41','Human Resource'),
	('d44','History'),
	('d45','Recreation, Parks and Leisure Services'),
	('d46','Construction Management'),
	('d48','Humanities'),
	('d49','French'),
	('d50','Mass Media'),
	('d51','Dental Hygiene'),
	('d52','Health Science'),
	('d53','Human Performance'),
	('d54','Finance'),
	('d55','Political Science'),
	('d56','Mechanical Engineering'),
	('d57','Electrical Engineering'),
	('d59','Educational Studies'),
	('d60','Family Consumer Science'),
	('d62','Psychology'),
	('d63','Sociology'),
	('d64','Scandinavian Studies'),
	('d65','Correction'),
	('d66','Ethnics'),
	('d67','Gender and Women Studies'),
	('d68','Law'),
	('d69','Military Science and Leadership'),
	('d70','Social Work'),
	('d71','Urban Studies'),
	('d73','Manufacturing Engineering Technology'),
	('d75','Special Education'),
	('d76','Secondary 5-12 and K 12 Professional Education'),
	('d77','Professional Education'),
	('d78','Communication Studies'),
	('d79','Geology'),
	('d80','Counseling and Student Personnel'),
	('d81','Educational Leadership'),
	('d82','First Year Experience'),
	('d83','German'),
	('d84','Gerontology'),
	('d85', 'Spanish'),
	('d86', 'American Indian Studies')
)
AS SOURCE ([DEPT_NUM], [DEPT_NAME])
ON TARGET.[DEPT_NUM] = SOURCE.[DEPT_NUM]

--Update matched rows
WHEN MATCHED THEN
UPDATE SET [DEPT_NAME] = SOURCE.[DEPT_NAME]

--INSERT WHEN NOT MATCHED
WHEN NOT MATCHED BY TARGET THEN
INSERT ([DEPT_NUM], [DEPT_NAME])
VALUES (SOURCE.[DEPT_NUM], SOURCE.[DEPT_NAME]);

----DELETE ROWS THAT ARE IN TARGET BUT NOT SOURCE
--WHEN NOT MATCHED BY SOURCE THEN
--DELETE;
GO

--SET IDENTITY_INSERT [dbo].[DEPARTMENT] OFF
--GO
	