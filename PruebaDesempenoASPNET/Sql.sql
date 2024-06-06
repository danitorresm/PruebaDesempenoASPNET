/**-*-*-*-*-*-*-*-*-*-*-*-*-*-*Tabla_Estudiantes*-*-*-*-*-*-**-*-*-*-*-*-*-*-*-*-*-*-*/
    CREATE TABLE Students(  
        Id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
        Names VARCHAR(125),
        BirthDate DATE,
        Address VARCHAR(125),
        Email VARCHAR(125)
    );
/**-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-**/

/**-*-*-*-*-*-*-*-*-*-*-*-*-*-*Tabla_Enrollments*-*-*-*-*-*-**-*-*-*-*-*-*-*-*-*-*-*-*/
    CREATE TABLE Enrollments(  
        Id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
        Date DATE,
        StudentId int (10),/*Conecta con la tabla Students*/
        CourseId int(10),/*Conecta con la tabla Courses*/
        Status ENUM("Activo", "Inactivo")
        
    );
    /*==============================================================================*/
    /*Relacion de Tabla Enrollments con Tabla Students*/
        ALTER TABLE Enrollments
        ADD FOREIGN KEY (StudentId)
        REFERENCES Students (Id);

    /*Relacion de Tabla Enrollments con Tabla Courses*/
        ALTER TABLE Enrollments
        ADD FOREIGN KEY (CourseId)
        REFERENCES Courses (Id);
    /*===========================================================================*/
/**-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-**/

/**-*-*-*-*-*-*-*-*-*-*-*-*-*-*Tabla_Courses*-*-*-*-*-*-**-*-*-*-*-*-*-*-*-*-*-*-*/
    CREATE TABLE Courses(  
        Id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
        Name VARCHAR(125),
        Description VARCHAR(125),
        TeacherId int(10),/*Conecta con la tabla Teachers*/
        Schedule VARCHAR(125),
        Duration VARCHAR(255),
        Capacity int (10)    
    );
    /*===========================================================================*/
    /*Relacion de Tabla Enrollments con Tabla Courses*/
        ALTER TABLE Courses
        ADD FOREIGN KEY (TeacherId)
        REFERENCES Teachers (Id);
    /*===========================================================================*/
/**-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-**/

/**-*-*-*-*-*-*-*-*-*-*-*-*-*-*Tabla_Teachers*-*-*-*-*-*-**-*-*-*-*-*-*-*-*-*-*-*-*/
    CREATE TABLE Teachers(  
        Id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
        Names VARCHAR(125),
        Speciality VARCHAR(125),
        Phone VARCHAR(25),
        Email VARCHAR(125),
        YearsExperience INT
    );
/**-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-**/