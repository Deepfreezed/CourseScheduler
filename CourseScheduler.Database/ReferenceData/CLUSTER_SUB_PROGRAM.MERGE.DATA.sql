MERGE INTO [dbo].[CLUSTER_SUB_PROGRAM] AS TARGET
USING (VALUES
----Computer Information Science----
('c01','s03','p001',11,'Core',0),
('c02','s03','p001',4,'Math Core',0),
('c03','s03','p001',3,'Communications Core',0),
('c01','s13','p001',8,'Cluster A',0),
('c02','s13','p001',8,'Cluster B',0),
('c03','s13','p001',8,'Cluster C',0),
--English Technical Communication--
('c01','s08','p003',16,'Required Courses for Major Common Core',0),
('c02','s08','p003',4,'Required Optional Courses for Major Common Core',0),
--Geography--
('c01','s13','p004',3,'Cultural-Systematic',0),
('c02','s13','p004',3,'Physical',0),
('c03','s13','p004',3,'Foreign Regional',0),
('c04','s13','p004',4,'Capstone Experience',0),
--Health and Physical Education--
('c03','s17','p005',4,'Level 1',0),
('c04','s17','p005',5,'Level 2',0),
('c05','s17','p005',6,'Level 3',0),
('c06','s17','p005',12,'Level 4',1),
('c01','s03','p005',19,'Required Courses for Required General Education',0),
('c02','s03','p005',3,'Required Optional Courses for Required General Education',0),
--Marketing--
('c01','s03','p006',10,'Required Courses for Required General Education',0),
('c02','s03','p006',3,'Required Optional Courses for Required General Education',0),
('c03','s08','p006',19,'Required of All College of Business Majors',0),
('c04','s08','p006',21,'Required for Marketing Major',0),
--Sport Management--
('c01','s03','p010',15,'Required Courses for Required General Education',0),
('c02','s03','p010',3,'Required Optional One Courses for Required General Education',0),
('c03','s03','p010',3,'Required Optional Two Courses for Required General Education',0),
--Statistics--
('c01','s18','p011',20,'Applied Mathematics Track',0),
('c02','s18','p011',20,'Computer Science Track',0),
('c03','s18','p011',20,'Biological Science Track',0),
--Computer Information Science Minor--
('c01','s05','p016',8,'Required Courses for Required for Minor',0),
('c02','s05','p016',12,'Required Optional Courses for Required for Minor',0),
--Computer Technology Minor--
('c01','s05','p017',12,'Required Courses for Required for Minor',0),
('c02','s05','p017',8,'Required Optional Courses for Required for Minor',0),
--Consumer Studies Minor--
('c01','s20','p014',17,'Required Courses for Consumer Related Courses',0),
('c02','s20','p014',3,'Required Optional Courses for Consumer Related Courses',0),
--Database Technologies Minor--
('c01','s05','p018',12,'Required Courses for Required for Minor',0),
('c02','s05','p018',8,'Required Optional Courses for Required for Minor',0),
--Military Science Minor--
('c01','s05','p021',23,'Required Courses for Required for Minor',0),
('c02','s05','p021',3,'Required Optional Courses for Required for Minor',0),
--Networking and Information Security Minor--
('c01','s05','p019',16,'Required Courses for Required for Minor',0),
('c02','s05','p019',4,'Required Optional Courses for Required for Minor',0),
--Software Development Minor--
('c01','s05','p020',16,'Required Courses for Required for Minor',0),
('c02','s05','p020',4,'Required Optional Courses for Required for Minor',0),
--Information Technology Masters--
('c01','s12','p022',8,'Database Technologies',0),
('c02','s12','p022',8,'Networking and Information Security',0),
('c03','s12','p022',8,'Software Development',0),
('c04','s02','p022',16,'600-level Electives',0),
('c05','s02','p022',99,'Other 500-level Electives',0),
('c06','s02','p022',8,'5/600-level Nondepartmental Courses',0),
--MBA--
('c03','s26','p023',6,'General',0),
('c01','s26','p023',6,'Leadership and Organizational Change',0),
('c02','s26','p023',6,'Global Business',0)
)
AS SOURCE ([CLUSTER_ID], [SUB_PROG_ID], [PROG_NUM], [CREDIT_HOURS], [NAME], [HAS_OPTIONS])
ON TARGET.[CLUSTER_ID] = SOURCE.[CLUSTER_ID]
	AND TARGET.[SUB_PROG_ID] = SOURCE.[SUB_PROG_ID]
	AND TARGET.[PROG_NUM] = SOURCE.[PROG_NUM]

--INSERT WHEN NOT MATCHED
WHEN NOT MATCHED BY TARGET THEN
INSERT ([CLUSTER_ID], [SUB_PROG_ID], [PROG_NUM], [CREDIT_HOURS], [NAME], [HAS_OPTIONS])
VALUES (SOURCE.[CLUSTER_ID], SOURCE.[SUB_PROG_ID], SOURCE.[PROG_NUM], SOURCE.[CREDIT_HOURS], SOURCE.[NAME], SOURCE.[HAS_OPTIONS]);

GO