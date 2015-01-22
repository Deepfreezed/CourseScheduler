MERGE INTO [dbo].[PROGRAM] AS TARGET
USING (VALUES
	('p001','Computer Information Technology','d01','BS','Undergraduate',0,NULL,'2012-2013','Yes'),
	('p002','Biotechnology','d26','BS','Undergraduate',0,NULL,'2012-2013','None'),
	('p003','English: Technical Communication','d02','BS','Undergraduate',0,NULL,'2012-2013','Yes'),
	('p004','Geography','d19','BA','Undergraduate',0,NULL,'2012-2013','Yes'),
	('p005','Health and Physical Education','d52','BS','Undergraduate',0,NULL,'2012-2013','None'),
	('p006','Marketing','d08','BS','Undergraduate',0,NULL,'2012-2013','None'),
	('p007','Mathematics','d03','BS','Undergraduate',0,NULL,'2012-2013','None'),
	('p008','Nursing','d05','BS','Undergraduate',0,NULL,'2012-2013','None'),
	('p009','Physics','d24','BS','Undergraduate',0,NULL,'2012-2013','None'),
	('p010','Sports Management','d53','BS','Undergraduate',0,NULL,'2012-2013','Yes'),
	('p011','Statistics','d03','BS','Undergraduate',0,NULL,'2012-2013','None'),
	('p012','Geology','d27','Minor','Undergraduate',0,NULL,'2012-2013','None'),
	('p013','Technical Communication','d02','Minor','Undergraduate',0,NULL,'2012-2013','None'),
	('p014','Consumer Studies','d60','Minor','Undergraduate',0,NULL,'2012-2013','None'),
	('p015','Business Law','d15','Minor','Undergraduate',0,NULL,'2012-2013','None'),
	('p016','Computer Information Science','d01','Minor','Undergraduate',0,NULL,'2012-2013','None'),
	('p017','Computer Technology','d01','Minor','Undergraduate',0,NULL,'2012-2013','None'),
	('p018','Database Technologies','d01','Minor','Undergraduate',0,NULL,'2012-2013','None'),
	('p019','Networking and Information Security','d01','Minor','Undergraduate',0,NULL,'2012-2013','None'),
	('p020','Software Development','d01','Minor','Undergraduate',0,NULL,'2012-2013','None'),
	('p021','Military Science','d69','Minor','Undergraduate',0,NULL,'2012-2013','None'),
	('p022','Information Technology','d01','MS','Graduate',0,NULL,'2012-2013','None'),
	('p023','Business Administration','d31','MBA','Graduate',0,NULL,'2012-2013','None'),
	('p024','Psychology','d62','PhD','Doctorate',0,NULL,'2012-2013','None')
)
AS SOURCE ([PROG_NUM], [PROG_NAME], [DEPT_NUM], [TYPE], [CLASS], [TOTAL_CH], [DESCRIPTION], [CATALOG_YEAR], [MINOR_REQUIRED])
ON TARGET.[PROG_NUM] = SOURCE.[PROG_NUM]

--INSERT WHEN NOT MATCHED
WHEN NOT MATCHED BY TARGET THEN
INSERT ([PROG_NUM], [PROG_NAME], [DEPT_NUM], [TYPE], [CLASS], [TOTAL_CH], [DESCRIPTION], [CATALOG_YEAR], [MINOR_REQUIRED])
VALUES (SOURCE.[PROG_NUM], SOURCE.[PROG_NAME], SOURCE.[DEPT_NUM], SOURCE.[TYPE], SOURCE.[CLASS], SOURCE.[TOTAL_CH], SOURCE.[DESCRIPTION], SOURCE.[CATALOG_YEAR], SOURCE.[MINOR_REQUIRED]);

GO