<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/sql" prefix="sql" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>


<c:out value="SQL tag lib usage"></c:out>
<sql:setDataSource var="con" driver="com.mysql.cj.jdbc.Driver" url="jdbc:mysql://localhost:3306/test" user="root" password=""></sql:setDataSource>

<sql:query dataSource="${con}" var="result" sql="select * from login1" startRow="0"></sql:query>
<c:out value="${result }"/>
<h1>Read the record....</h1> 
