-- JOINS
SELECT e.nombre, e.apellido, d.dnombre AS 'Departamento' FROM empleado e JOIN departamento d ON d.dnumero = e.dno;
SELECT  c.eci,e.nombre, e.apellido, c.dep_nom, c.relacion FROM empleado e JOIN carga_f c ON ci=eci WHERE c.sexo LIKE '%F%';
SELECT p.pnombre, p.dnum, d.dnombre FROM departamento d RIGHT JOIN proyecto p ON d.dnumero = p.dnum WHERE d.dnombre LIKE '%Compras%';
SELECT p.pnombre AS 'Nombre del proyecto', CONCAT_WS(' ',e.nombre, e.apellido) AS 'Nombre del empleado' FROM proyecto p JOIN trabaja_en t ON p.pnumero = t.pno LEFT JOIN empleado e ON t.eci = e.ci WHERE e.ci IS NOT NULL;
SELECT e.nombre, CONCAT(em.nombre,' ',em.superci) AS 'Supervisor' FROM empleado e JOIN empleado em ON e.superci = em.ci;
SELECT  c.eci,e.nombre, e.apellido, c.dep_nom, c.relacion FROM empleado e LEFT JOIN carga_f c ON e.ci = c.eci WHERE c.eci IS NULL;
SELECT p.pnombre, p.plocal FROM proyecto p JOIN departamento d ON d.dnumero = p.dnum JOIN localizacion l WHERE l.dep_loca LIKE '%Quito%' AND p.plocal LIKE '%Quito%';
SELECT concat_ws(" ",e.nombre, e.apellido) AS "Nombre completo" FROM empleado e JOIN trabaja_en t ON e.ci = t.eci GROUP BY t.eci HAVING count(t.eci)>1;
SELECT e.nombre, e.apellido, p.pnombre FROM empleado e JOIN trabaja_en t ON e.ci = t.eci JOIN proyecto p ON t.pno = p.pnumero WHERE p.pnombre LIKE '%ProductoZ%';
SELECT e.nombre, e.apellido, p.pnombre, d.dnombre, c.dep_nom, c.relacion FROM empleado e JOIN trabaja_en t ON e.ci = t.eci JOIN proyecto p ON p.pnumero = t.pno JOIN departamento d ON e.dno = d.dnumero AND p.dnum IS NOT NULL JOIN carga_f c ON e.ci = c.eci WHERE c.sexo = 'M';
-- SUBCONSULTAS 
SELECT e.nombre, e.apellido FROM empleado e WHERE e.dno IN (SELECT d.dnumero FROM departamento d WHERE d.dnombre LIKE '%Administrativo%');
SELECT * FROM proyecto p WHERE p.pnumero IN (SELECT DISTINCT(pno) FROM trabaja_en t WHERE t.eci IN (SELECT ci FROM empleado e WHERE e.ci IN (SELECT eci FROM carga_f c WHERE c.sexo = 'F')));
SELECT * FROM departamento WHERE dnumero IN (SELECT DISTINCT (dno) FROM empleado WHERE salario = (SELECT max(salario) FROM empleado));
SELECT * FROM empleado WHERE ci NOT IN (SELECT DISTINCT(eci) FROM carga_f);
SELECT * FROM proyecto WHERE dnum IN (SELECT dnumero FROM departamento WHERE dnombre = 'Compras');
SELECT * FROM departamento WHERE dnumero IN (SELECT dno FROM empleado GROUP BY dno HAVING SUM(dno) > 2);
-- VISTAS
CREATE VIEW Diez AS (SELECT e.nombre, e.apellido, p.pnombre FROM empleado e JOIN trabaja_en t ON e.ci = t.eci JOIN proyecto p ON t.pno = p.pnumero WHERE p.pnombre LIKE '%ProductoZ%');
CREATE VIEW Once AS (SELECT e.nombre, e.apellido FROM empleado e WHERE e.dno IN (SELECT d.dnumero FROM departamento d WHERE d.dnombre LIKE '%Administrativo%'));
ALTER VIEW Once AS (SELECT e.nombre, e.apellido FROM empleado e WHERE e.dno IN (SELECT d.dnumero FROM departamento d WHERE d.dnombre LIKE '%Investigacion%'));
DROP VIEW Once;
