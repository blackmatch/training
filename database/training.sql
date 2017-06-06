DROP DATABASE training;
CREATE DATABASE training;
USE training;

--学员表
CREATE TABLE trainees(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(30) NOT NULL,
	gender VARCHAR(5) NULL,
	age INT NULL,
	jobNumber INT NOT NULL,		--工号
	pwd VARCHAR(200) DEFAULT 'e10adc3949ba59abbe56e057f20f883e', --123456，MD5加密
	UNIQUE(jobNumber)
);

--教员表
CREATE TABLE instructors(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(30) NOT NULL,
	gender VARCHAR(5) NULL,
	age INT NULL,
	istNumber INT NOT NULL, --教员编号
	pwd VARCHAR(200) DEFAULT 'e10adc3949ba59abbe56e057f20f883e',
	UNIQUE(istNumber)
);

--管理员表
CREATE TABLE admins(
	id INT IDENTITY(1,1) PRIMARY KEY,
	userName VARCHAR(30) NOT NULL,
	pwd VARCHAR(200) DEFAULT 'e10adc3949ba59abbe56e057f20f883e',
	UNIQUE(userName)
);

--课程表
CREATE TABLE courses(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(200) NOT NULL,
	ist_id INT NOT NULL, --教员id
	beginDate DATETIME NOT NULL,
	endDate DATETIME NOT NULL,
	addr VARCHAR(200) NULL, --上课地点
	flag TINYINT DEFAULT 0, --课程状态,0已创建，1进行中，2已结束，3已取消
	remark VARCHAR(300) NULL --备注
	FOREIGN KEY (ist_id) REFERENCES instructors(id)
);

--报名表
CREATE TABLE enrollment(
	id INT IDENTITY(1,1) PRIMARY KEY,
	course_id INT NOT NULL,
	trainee_id INT NOT NULL,
	createdAt DATETIME DEFAULT GETDATE(),	--报名时间
	FOREIGN KEY (course_id) REFERENCES courses(id),
	FOREIGN KEY (trainee_id) REFERENCES trainees(id),
	UNIQUE(course_id,trainee_id)
);

--课程评论表（学员对课程的评论）
CREATE TABLE comments(
	id INT IDENTITY(1,1) PRIMARY KEY,
	course_id INT NOT NULL,
	trainee_id INT NOT NULL,
	content VARCHAR(300) NOT NULL, --评论内容
	createdAt DATETIME DEFAULT GETDATE(),	--评论时间
	FOREIGN KEY (course_id) REFERENCES courses(id),
	FOREIGN KEY (trainee_id) REFERENCES trainees(id)
);

--成绩表（教员针对某一课程对学员打分）
CREATE TABLE score(
	id INT IDENTITY(1,1) PRIMARY KEY,
	course_id INT NOT NULL,
	trainee_id INT NOT NULL,
	score FLOAT NOT NULL,	--得分
	evaluation VARCHAR(300) NULL, --评语
	FOREIGN KEY (course_id) REFERENCES courses(id),
	FOREIGN KEY (trainee_id) REFERENCES trainees(id)
);

--考勤表（主要是记录缺勤情况）
CREATE TABLE attendance(
	id INT IDENTITY(1,1) PRIMARY KEY,
	course_id INT NOT NULL,
	trainee_id INT NOT NULL,
	absenceTime DATETIME NOT NULL,	--缺席时间
	remark VARCHAR(300) NULL, --备注
	FOREIGN KEY (course_id) REFERENCES courses(id),
	FOREIGN KEY (trainee_id) REFERENCES trainees(id)
);
