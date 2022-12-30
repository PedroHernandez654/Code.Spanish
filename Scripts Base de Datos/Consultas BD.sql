-- COMPOSICION INTERNA
SELECT p.id AS 'Matricula',CONCAT_WS(' ',p.nombre,p.apellido1,p.Apellido2) AS 'Alumna', g.id AS 'Grado', g.nombre AS 'Grado Titulo' FROM grado g LEFT JOIN asignatura a ON a.id_grado = g.id JOIN alumno_se_matricula_asignatura m ON m.id_asignatura = a.id JOIN persona p ON p.id = m.id_alumno WHERE (p.sexo = 'M'  AND p.tipo = 'alumno');
SELECT a.id AS 'Matricula', a.nombre AS 'Asignatura' FROM asignatura a LEFT JOIN grado g ON (a.id = g.id) WHERE a.id_grado = 4;
SELECT p.nombre AS 'Nombre', p.apellido1 AS 'Primer Apellido', p.apellido2 AS 'Segundo Apellido', d.nombre AS 'Materia' FROM persona p RIGHT JOIN profesor pro ON pro.id_profesor = p.id JOIN departamento d ON pro.id_departamento = d.id ORDER BY p.nombre , p.apellido1, apellido2 ASC;
SELECT CONCAT_WS(' ',p.nombre, p.apellido1, p.apellido2) AS 'Nombre del alumno',a.nombre AS 'Asignatura', c.anyo_inicio AS 'Año de inicio', c.anyo_fin AS 'Año final' FROM curso_escolar c JOIN alumno_se_matricula_asignatura m ON m.id_curso_escolar = c.id JOIN asignatura a ON m.id_asignatura = a.id JOIN persona p ON m.id_alumno = p.id WHERE p.nif = '26902806M';
SELECT d.id AS 'Matricula', d.nombre AS 'Departamento', p.id_profesor AS 'Matricula del profesor' FROM departamento d LEFT JOIN profesor p ON d.id = p.id_departamento JOIN asignatura a USING (id_profesor) JOIN grado g ON a.id_grado = g.id WHERE g.nombre = 'Grado en Ingeniería Informática (Plan 2015)' GROUP BY p.id_profesor;
-- CONSULTAS EXTERNAS
SELECT p.nombre, p.apellido1, p.apellido2, d.nombre AS 'Departamentos' FROM persona p RIGHT JOIN profesor pr ON p.id = pr.id_profesor  JOIN departamento d ON d.id = pr.id_departamento;
SELECT p.* FROM profesor p LEFT JOIN departamento d ON p.id_departamento= d.id WHERE  d.id IS NULL;
SELECT d.* FROM profesor p RIGHT JOIN departamento d ON p.id_departamento= d.id WHERE p.id_departamento IS NULL;
SELECT p.* FROM profesor p LEFT JOIN asignatura a ON p.id_profesor = a.id_profesor WHERE a.id_profesor IS NULL;
SELECT a.* FROM asignatura a LEFT JOIN profesor p ON p.id_profesor = a.id_profesor WHERE a.id_profesor IS NULL;
-- SUBCONSULTAS
SELECT * FROM persona WHERE fecha_nacimiento = (SELECT max(fecha_nacimiento) FROM persona p,alumno_se_matricula_asignatura a WHERE a.id_alumno = p.id);
SELECT * FROM profesor WHERE id_departamento NOT IN (SELECT id FROM persona);
SELECT p.id_profesor, p.id_departamento FROM profesor p WHERE NOT EXISTS (SELECT a.id_profesor FROM asignatura a WHERE a.id_profesor = p.id_profesor);
SELECT * FROM asignatura a WHERE NOT EXISTS (SELECT p.id_profesor FROM profesor p WHERE a.id_profesor = p.id_profesor);
SELECT d.nombre FROM departamento d WHERE id NOT IN (SELECT id_departamento FROM profesor);
-- VISTAS
CREATE VIEW Tres AS (SELECT p.nombre AS 'Nombre', p.apellido1 AS 'Primer Apellido', p.apellido2 AS 'Segundo Apellido', d.nombre AS 'Materia' FROM persona p RIGHT JOIN profesor pro ON pro.id_profesor = p.id JOIN departamento d ON pro.id_departamento = d.id ORDER BY p.nombre , p.apellido1, apellido2 ASC);
CREATE VIEW Cuatro AS (SELECT CONCAT_WS(' ',p.nombre, p.apellido1, p.apellido2) AS 'Nombre del alumno',a.nombre AS 'Asignatura', c.anyo_inicio AS 'Año de inicio', c.anyo_fin AS 'Año final' FROM curso_escolar c JOIN alumno_se_matricula_asignatura m ON m.id_curso_escolar = c.id JOIN asignatura a ON m.id_asignatura = a.id JOIN persona p ON m.id_alumno = p.id WHERE p.nif = '26902806M');
CREATE VIEW Seis AS (SELECT p.nombre, p.apellido1, p.apellido2, d.nombre AS 'Departamentos' FROM persona p RIGHT JOIN profesor pr ON p.id = pr.id_profesor  JOIN departamento d ON d.id = pr.id_departamento);
ALTER VIEW Cuatro AS (SELECT CONCAT_WS(' ',p.nombre, p.apellido1, p.apellido2) AS 'Nombre del alumno',a.nombre AS 'Asignatura', c.anyo_inicio AS 'Año de inicio', c.anyo_fin AS 'Año final' FROM curso_escolar c JOIN alumno_se_matricula_asignatura m ON m.id_curso_escolar = c.id JOIN asignatura a ON m.id_asignatura = a.id JOIN persona p ON m.id_alumno = p.id WHERE p.nif = '46900725E');
DROP VIEW Tres;