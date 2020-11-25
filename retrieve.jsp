
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>

<jsp:useBean id="bone" class="in.ac.vce.MySQLBean" scope="session">
<!-- EL expression or Expression Language -->
<jsp:setProperty name="bone" property="username" value="${para.username }"/>
<!-- MySQLBean bone = new MySQLBean() -->
<jsp:getProperty name="bone" property="store"/>
<jsp:getProperty name="bone" property="username"/>
<jsp:getProperty name="bone" property="password" />

</jsp:useBean>
