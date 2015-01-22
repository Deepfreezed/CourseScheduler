/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--:r ".\DEPARTMENT.DATA.sql"
:r ".\DEPARTMENT.MERGE.DATA.sql"
PRINT 'DONE DEPARTMENT.DATA.sql'
GO 
:r ".\COURSE_OFFERING.MERGE.DATA.sql"
PRINT 'DONE COURSE_OFFERING.MERGE.DATA.sql'
GO
:r ".\COURSE.MERGE.DATA.sql"
PRINT 'DONE COURSE.MERGE.DATA.sql'
GO
:r ".\PROGRAM.MERGE.DATA.sql"
PRINT 'DONE PROGRAM.MERGE.DATA.sql'
GO
:r ".\SUB_PROGRAM_IDENTIFIER.MERGE.DATA.sql"
PRINT 'DONE SUB_PROGRAM_IDENTIFIER.MERGE.DATA.sql'
GO
:r ".\SUB_PROGRAM.MERGE.DATA.sql"
PRINT 'DONE SUB_PROGRAM.MERGE.DATA.sql'
GO
:r ".\COURSE_SUB_PROGRAM.MERGE.DATA.sql"
PRINT 'DONE COURSE_SUB_PROGRAM.MERGE.DATA.sql'
GO
:r ".\CLUSTER_SUB_PROGRAM.MERGE.DATA.sql"
PRINT 'DONE CLUSTER_SUB_PROGRAM.MERGE.DATA.sql'
GO
:r ".\COURSE_CLUSTER_SUB_PROGRAM.MERGE.DATA.sql"
PRINT 'DONE COURSE_CLUSTER_SUB_PROGRAM.MERGE.DATA.sql'
GO
:r ".\OPTIONAL_CLUSTER_SUB_PROGRAM.MERGE.DATA.sql"
PRINT 'DONE OPTIONAL_CLUSTER_SUB_PROGRAM.MERGE.DATA.sql'
GO
:r ".\COURSE_OPTION_CLUSTER_SUB_PROG.MERGE.DATA.sql"
PRINT 'DONE COURSE_OPTION_CLUSTER_SUB_PROG.MERGE.DATA.sql'
GO
:r ".\PREREQUISITE.MERGE.DATA.sql"
PRINT 'DONE PREREQUISITE.MERGE.DATA.sql'
GO
:r ".\GOAL_AREA.MERGE.DATA.sql"
PRINT 'DONE GOAL_AREA.MERGE.DATA.sql'
GO
:r ".\GEN_ED_COURSE.MERGE.DATA.sql"
PRINT 'DONE GEN_ED_COURSE.MERGE.DATA.sql'
GO
:r ".\TEACHER.MERGE.DATA.sql"
PRINT 'DONE TEACHER.MERGE.DATA.sql'
GO
:r ".\NON_CLUSTERED_INDEXES.sql"
PRINT 'DONE NON_CLUSTERED_INDEXES.sql'
GO