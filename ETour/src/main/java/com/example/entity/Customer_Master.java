package com.example.entity;

import java.util.Set;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.OneToMany;
import jakarta.persistence.OneToOne;
import jakarta.persistence.Table;
@Entity
@Table(name="Customer_Master")
public class Customer_Master {
	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
    private int cust_id;
	private String first_name;
	private String last_name;
	private int age;
	private String gender;
	private int country_code;
	private long mo_no;
	private String address;
	private String email;
	private long adhar_no;
	@OneToMany(cascade = CascadeType.ALL )
	@JoinColumn(name = "cust_id")
	private Set<Booking_Header> bookingheader;
	
	public int getCust_id() {
		return cust_id;
	}
	public void setCust_id(int cust_id) {
		this.cust_id = cust_id;
	}
	public String getFirst_name() {
		return first_name;
	}
	public void setFirst_name(String first_name) {
		this.first_name = first_name;
	}
	public String getLast_name() {
		return last_name;
	}
	public void setLast_name(String last_name) {
		this.last_name = last_name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getGender() {
		return gender;
	}
	public void setGender(String gender) {
		this.gender = gender;
	}
	public int getCountry_code() {
		return country_code;
	}
	public void setCountry_code(int country_code) {
		this.country_code = country_code;
	}
	public long getMo_no() {
		return mo_no;
	}
	public void setMo_no(long mo_no) {
		this.mo_no = mo_no;
	}
	public String getAddress() {
		return address;
	}
	public void setAddress(String address) {
		this.address = address;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public long getAdhar_no() {
		return adhar_no;
	}
	public void setAdhar_no(long adhar_no) {
		this.adhar_no = adhar_no;
	}
	public Set<Booking_Header> getBookingheader() {
		return bookingheader;
	}
	public void setBookingheader(Set<Booking_Header> bookingheader) {
		this.bookingheader = bookingheader;
	}
	
}
