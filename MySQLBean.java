package in.ac.vce;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;



public class MySQLBean implements java.io.Serializable{
	private String username, password;
	private int store;
	public String getUsername() {
		return username;
	}
	public void setUsername(String username) {
		this.username = username;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	public int getStore() throws Exception{
		Connection con = new MySqlConnection().MySqlConnec();
		String sql = "select * from login1 where username=?";
		
		PreparedStatement ps = con.prepareStatement(sql);
		ps.setString(1,this.username);
		ResultSet rs = ps.executeQuery();
		if(rs.next()) {
			this.username = rs.getString(1);
			this.password = rs.getString(2);
		}
		return 1;
		
	}
	public void setStore(int store) throws Exception{
		Connection con = new MySqlConnection().MySqlConnec();
		String sql = "insert into login1(username,password) values(?,?);";
		PreparedStatement ps = con.prepareStatement(sql);
		ps.setString(1, this.username);
		ps.setString(2, this.password);
		ps.executeUpdate();
		System.out.println("Did you come here");
		ps.close();
		con.close();
	}
}
