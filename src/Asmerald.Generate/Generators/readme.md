## Oracle

https://stackoverflow.com/questions/37014740/oracle-which-sql-command-to-get-all-details-about-a-table

SELECT table_name, owner, Tablespace_name, Num_Rows 
FROM all_tables 
ORDER BY  owner, table_name;

SELECT * 
FROM all_tables 
WHERE owner in ('USER_4_C7C1E0');

SELECT * 
FROM all_views
WHERE owner in ('USER_4_C7C1E0');

SELECT *
FROM user_procedures;

SELECT * 
From all_tab_cols 
where  owner in ('USER_4_C7C1E0');

SELECT * 
From all_vw_cols 
where  owner in ('USER_4_C7C1E0');

SELECT owner, object_name
FROM all_objects
where object_name = 'FUNCTION';

CREATE PROCEDURE remove_emp (employee_id NUMBER) AS
   BEGIN
      DELETE FROM EMP
      WHERE EMP.EMPNO = remove_emp.employee_id;
   END;
   
CREATE FUNCTION get_balw(acc_no IN NUMBER) 
   RETURN NUMBER 
   IS acc_bal NUMBER(11,2);
   BEGIN 
      RETURN acc_no; 
    END;
    
    select get_balw(2) from emp;



## Postgresql

## MySql

## MariaDb

## MSSql
https://stackoverflow.com/questions/3913620/get-all-table-names-of-a-particular-database-by-sql-query

SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES


http://sqlfiddle.com/#!4/c7c1e0/14