/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [sfzh]
      ,[xm]
      ,[zyfx]
      ,[xh]
      ,[teacher]
      ,[reason]
      ,[isSuggested]
      ,[share]
  FROM [qds157524694_db].[dbo].[zmjs_studentsInfo] where xh='111'

delete from zmjs_studentsInfo where xh='111'

insert into zmjs_studentsInfo(sfzh,xm,xh) values('130202196666668967','测姓名','111')