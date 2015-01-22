MERGE INTO [dbo].[SUB_PROGRAM] AS TARGET
USING (VALUES
	----Computer Information Science----
	('p001','s08',47,0),
	('p001','s03',18,1),
	('p001','s13',8,1),
	--Biotechnology--
	('p002','s03',13,0),
	('p002','s14',12,0),
	('p002','s08',58,0),
	('p002','s13',6,0),
	--English Technical Communication--
	('p003','s08',20,1),
	('p003','s13',19,0),
	--Geography--
	('p004','s08',13,0),
	('p004','s13',13,1),
	('p004','s16',8,0),
	--Health and Physical Education--
	('p005','s03',22,1),
	('p005','s14',8,0),
	('p005','s08',41,0),
	('p005','s17',27,1),
	--Marketing--
	('p006','s03',13,1),
	('p006','s14',17,0),
	('p006','s08',21,1),
	('p006','s16',6,0),
	--Math--
	('p007','s03',4,0),
	('p007','s08',19,0),
	('p007','s13',8,0),
	('p007','s16',12,0),
	--Nursing--
	('p008','s03',40,0),
	('p008','s14',20,0),
	('p008','s18',59,0),
	--Physics--
	('p009','s03',8,0),
	('p009','s08',56,0),
	('p009','s16',4,0),
	--Sport Management--
	('p010','s03',21,1),
	('p010','s14',4,0),
	('p010','s08',38,0),
	('p010','s13',6,0),
	--Statistics--
	('p011','s03',4,0),
	('p011','s11',56,0),
	('p011','s18',20,1),
	--Business Law Minor--
	('p015','s05',15,0),
	('p015','s12',6,0),
	--Computer Information Science Minor--
	('p016','s05',20,1),
	--Computer Technology Minor--
	('p017','s05',20,1),
	--Consumer Studies Minor--
	('p014','s01',3,0),
	('p014','s20',20,1),
	('p014','s21',6,0),
	--Database Technologies Minor--
	('p018','s05',20,1),
	--Geology Minor--
	('p012','s05',12,0),
	('p012','s19',6,0),
	--Military Science Minor--
	('p021','s05',27,1),
	--Networking and Information Security Minor--
	('p019','s05',20,1),
	--Software Development Minor--
	('p020','s05',20,1),
	--Technical Communication Minor--
	('p013','s05',8,0),
	('p013','s19',8,0),
	--Information Technology Masters--
	('p022','s22',13,0),
	('p022','s12',8,1),
	('p022','s02',15,1),
	('p022','s23',6,0),
	--MBA--
	('p023','s24',6,0),
	('p023','s01',14,0),
	('p023','s25',8,0),
	('p023','s26',6,1),
	--Psychology PhD--
	('p024','s27',22,0),
	('p024','s28',9,0),
	('p024','s29',18,0),
	('p024','s30',17,0),
	('p024','s31',16,0),
	('p024','s32',24,0)
)
AS SOURCE ([PROG_NUM], [SUB_PROG_ID], [CREDIT_HOURS], [HAS_CLUSTERS])
ON TARGET.[PROG_NUM] = SOURCE.[PROG_NUM] AND TARGET.[SUB_PROG_ID] = SOURCE.[SUB_PROG_ID]


--INSERT WHEN NOT MATCHED
WHEN NOT MATCHED BY TARGET THEN
INSERT ([PROG_NUM], [SUB_PROG_ID], [CREDIT_HOURS], [HAS_CLUSTERS])
VALUES (SOURCE.[PROG_NUM], SOURCE.[SUB_PROG_ID], SOURCE.[CREDIT_HOURS], SOURCE.[HAS_CLUSTERS]);

GO