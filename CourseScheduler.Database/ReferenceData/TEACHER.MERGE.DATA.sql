MERGE INTO [dbo].[TEACHER] AS TARGET
USING (VALUES
('t31', 'd01', 'Asher', 'Gregg'),
('t50', 'd01', 'Tietz', 'Leon'),
('t39', 'd01', 'Hart', 'Allan'),
('t53', 'd01', 'Wells', 'Michael'),
('t48', 'd01', 'Slack', 'James'),
('t49', 'd01', 'Syed', 'Mahbubur'),
('t52', 'd01', 'Veltsos', 'Christophe'),
('t32', 'd01', 'Azarbod', 'Cyrus'),
('t09', 'd02', 'Anderson', 'Ryan'),
('t26', 'd02', 'Culpeppar', 'Dante'),
('t11', 'd03', 'Williams', 'Mike'),
('t10', 'd03', 'Vincent', 'Cheryl'),
('t27', 'd03', 'Kleinsassar', 'Jim'),
('t59', 'd04', 'Kawatra', 'Rakesh'),
('t23', 'd04', 'Potter', 'Harry'),
('t21', 'd07', 'Jones', 'Jaque'),
('t80', 'd08', 'Broomy', 'Penny'),
('t58', 'd08', 'Milan', 'Penny'),
('t46', 'd09', 'Sanchez', 'Julio'),
('t62', 'd12', 'Paffinger', 'Justin'),
('t02', 'd13', 'Green', 'Pam'),
('t66', 'd14', 'laila', 'Swami'),
('t78', 'd15', 'Martine', 'Harvey'),
('t45', 'd16', 'Mota', 'Paraish'),
('t44', 'd16', 'Roiger', 'Roiger'),
('t75', 'd16', 'James', 'Tiger'),
('t79', 'd16', 'Gaspar', 'Paul'),
('t60', 'd16', 'Kawatra', 'Rakesh'),
('t24', 'd16', 'Potter', 'Harry'),
('t72', 'd18', 'Duggles', 'Mike'),
('t73', 'd19', 'Warne', 'Norleen'),
('t74', 'd20', 'Cambell', 'Alistar'),
('t77', 'd20', 'Martine', 'Harvey'),
('t70', 'd21', 'Dave', 'Alisio'),
('t81', 'd24', 'Jenkins', ' '),
('t82', 'd24', 'Colins', ' '),
('t83', 'd25', 'Jermin', ' '),
('t84', 'd25', 'Red', ' '),
('t85', 'd26', 'Menandez', 'Julio'),
('t86', 'd26', 'White', 'John'),
('t87', 'd27', 'Jones', 'Josh'),
('t88', 'd27', 'Ali', 'Jafar')
)
AS SOURCE ([TEACHER_NUM], [DEPT_NUM], [LNAME], [FNAME])
ON TARGET.[TEACHER_NUM] = SOURCE.[TEACHER_NUM]

--INSERT WHEN NOT MATCHED
WHEN NOT MATCHED BY TARGET THEN
INSERT ([TEACHER_NUM], [DEPT_NUM], [LNAME], [FNAME])
VALUES (SOURCE.[TEACHER_NUM], SOURCE.[DEPT_NUM], SOURCE.[LNAME], SOURCE.[FNAME]);

GO