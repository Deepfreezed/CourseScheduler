MERGE INTO [dbo].[SUB_PROGRAM_IDENTIFIER] AS TARGET
USING (VALUES
	('s01','Core','Core'),
	('s02','Electives','Elective'),
	('s03','Required General Education','General Education'),
	('s04','General Education','General Education'),
	('s05','Required for Minor','Core'),
	('s06','Optional','Elective'),
	('s07','Alternate Plan Paper','Research'),
	('s08','Major Common Core','Core'),
	('s09','Master','Core'),
	('s10','Required Support Courses','Elective'),
	('s11','Required for Major','Core'),
	('s12','Required Electives','Elective'),
	('s13','Major Restricted Electives','Elective'),
	('s14','Prerequisite to the Major','Core'),
	('s15','Required Minor','Core'),
	('s16','Major Unrestricted Electives','Elective'),
	('s17','Other Graduation Requirements','Research'),
	('s18','Major Emphasis','Core'),
	('s19','Required Electives for Minor','Elective'),
	('s20','Consumer Related Courses','Core'),
	('s21','Strongly Recommended Electives','Elective'),
	('s22','Required Core','Core'),
	('s23','Required Capstone Experience','Research'),
	('s24','Tool Courses','Core'),
	('s25','Strategy Courses','Core'),
	('s26','Concentrations','Elective'),
	('s27','Professional Experiences','Core'),
	('s28','Diversity and Disability','Core'),
	('s29','Psych/Ed Foundations','Core'),
	('s30','Assessment','Core'),
	('s31','Intervention/Prevention','Core'),
	('s32','Research','Research')
)
AS SOURCE ([SUB_PROG_ID], [NAME], [COMMON_NAME])
ON TARGET.[SUB_PROG_ID] = SOURCE.[SUB_PROG_ID]

--INSERT WHEN NOT MATCHED
WHEN NOT MATCHED BY TARGET THEN
INSERT ([SUB_PROG_ID], [NAME], [COMMON_NAME])
VALUES (SOURCE.[SUB_PROG_ID], SOURCE.[NAME], SOURCE.[COMMON_NAME]);

GO