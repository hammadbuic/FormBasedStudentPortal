# FormBasedStudentPortal
Student Portal (Windows Form Applicationn) in .NET
Following are the key Features of the Code

1. Create Student profile

For create user profile store the following information against student object
- Student ID (Unique)
- Student Name
- Semseter
- CGPA
- Department
- University
Screen:
![image](https://user-images.githubusercontent.com/50557442/69901576-5aac6300-13a5-11ea-9fb0-7883aeac7b0c.png)

2. Search Student
For search student please provide the following searche options in menu and user should select the search option

1. Search By ID (Will only return 1 student)
2. Search By Name (Will return all student having same name)
3. List Number of Students (With selecting option 3 list of all students will be displayed)
Screens:
![image](https://user-images.githubusercontent.com/50557442/69901637-3ef58c80-13a6-11ea-89c7-176f07cc8dd8.png)
![image](https://user-images.githubusercontent.com/50557442/69901645-5df41e80-13a6-11ea-9438-ed1ec4433725.png)
![image](https://user-images.githubusercontent.com/50557442/69901674-79f7c000-13a6-11ea-8946-3d93227e30ee.png)

3. Delete Student Record
Delete student will be based on student id as following
- Enter Student ID (if id is correct and student record exist it should be removed and a success response should be generated)
Screens:
![image](https://user-images.githubusercontent.com/50557442/69901704-d1962b80-13a6-11ea-8950-88ad12b1f175.png)

4. List top 03 of class
Top 3 students will be shown with the heighest CGPA
Screens:
![image](https://user-images.githubusercontent.com/50557442/69901724-1621c700-13a7-11ea-89da-b3ce9692a5ee.png)

5. Mark student attendance
Mark attdendance will show id and name of each student and user will be asked to set attendance. (We are going to store only one attendance record)
Screens:
![image](https://user-images.githubusercontent.com/50557442/69901740-60a34380-13a7-11ea-987a-6e7f5dfb83fe.png)

6. View attendance
View attendance will display the list of students with attendance (id, name, attendance)
Screens:
![image](https://user-images.githubusercontent.com/50557442/69901748-93e5d280-13a7-11ea-8482-4b11ae5be853.png)

The Program have File path saved in app.config file
