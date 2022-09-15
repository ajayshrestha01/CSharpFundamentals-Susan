insert into Student (Name, Address, Email, DOB, Gender)
values ('Rishab Khatiwada', 'Bhaktapur', 'SU@gmail.com', '2010/12/12', 'M')

--update statement
update Student set Address= 'Lalitpur'
where Id = 1

--selection/Projection
select * from Student --* means selects every values stated above

--select all female students who lives in Lalitpur
select * from Student
where Gender = 'F' and Address = 'Lalitpur'

--order student by their name
select * from Student
order by Name asc

--Find number of students living in each city
--use agrregate function-COUNT
--s: alias
select s.Address, COUNT (*) as NumberOfStudents from Student as s
Group by Address