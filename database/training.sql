DROP DATABASE training;
CREATE DATABASE training;
USE training;

--ѧԱ��
CREATE TABLE trainees(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(30) NOT NULL,
	gender VARCHAR(5) NULL,
	age INT NULL,
	jobNumber INT NOT NULL,		--����
	pwd VARCHAR(200) DEFAULT 'e10adc3949ba59abbe56e057f20f883e', --123456��MD5����
	UNIQUE(jobNumber)
);

--��Ա��
CREATE TABLE instructors(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(30) NOT NULL,
	gender VARCHAR(5) NULL,
	age INT NULL,
	istNumber INT NOT NULL, --��Ա���
	pwd VARCHAR(200) DEFAULT 'e10adc3949ba59abbe56e057f20f883e',
	UNIQUE(istNumber)
);

--����Ա��
CREATE TABLE admins(
	id INT IDENTITY(1,1) PRIMARY KEY,
	userName VARCHAR(30) NOT NULL,
	pwd VARCHAR(200) DEFAULT 'e10adc3949ba59abbe56e057f20f883e',
	UNIQUE(userName)
);

--�γ̱�
CREATE TABLE courses(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(200) NOT NULL,
	ist_id INT NOT NULL, --��Աid
	beginDate DATETIME NOT NULL,
	endDate DATETIME NOT NULL,
	addr VARCHAR(200) NULL, --�Ͽεص�
	flag TINYINT DEFAULT 0, --�γ�״̬,0�Ѵ�����1�����У�2�ѽ�����3��ȡ��
	remark VARCHAR(300) NULL --��ע
	FOREIGN KEY (ist_id) REFERENCES instructors(id)
);

--������
CREATE TABLE enrollment(
	id INT IDENTITY(1,1) PRIMARY KEY,
	course_id INT NOT NULL,
	trainee_id INT NOT NULL,
	createdAt DATETIME DEFAULT GETDATE(),	--����ʱ��
	FOREIGN KEY (course_id) REFERENCES courses(id),
	FOREIGN KEY (trainee_id) REFERENCES trainees(id),
	UNIQUE(course_id,trainee_id)
);

--�γ����۱�ѧԱ�Կγ̵����ۣ�
CREATE TABLE comments(
	id INT IDENTITY(1,1) PRIMARY KEY,
	course_id INT NOT NULL,
	trainee_id INT NOT NULL,
	content VARCHAR(300) NOT NULL, --��������
	createdAt DATETIME DEFAULT GETDATE(),	--����ʱ��
	FOREIGN KEY (course_id) REFERENCES courses(id),
	FOREIGN KEY (trainee_id) REFERENCES trainees(id)
);

--�ɼ�����Ա���ĳһ�γ̶�ѧԱ��֣�
CREATE TABLE score(
	id INT IDENTITY(1,1) PRIMARY KEY,
	course_id INT NOT NULL,
	trainee_id INT NOT NULL,
	score FLOAT NOT NULL,	--�÷�
	evaluation VARCHAR(300) NULL, --����
	FOREIGN KEY (course_id) REFERENCES courses(id),
	FOREIGN KEY (trainee_id) REFERENCES trainees(id)
);

--���ڱ���Ҫ�Ǽ�¼ȱ�������
CREATE TABLE attendance(
	id INT IDENTITY(1,1) PRIMARY KEY,
	course_id INT NOT NULL,
	trainee_id INT NOT NULL,
	absenceTime DATETIME NOT NULL,	--ȱϯʱ��
	remark VARCHAR(300) NULL, --��ע
	FOREIGN KEY (course_id) REFERENCES courses(id),
	FOREIGN KEY (trainee_id) REFERENCES trainees(id)
);
