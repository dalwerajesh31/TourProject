package com.example.entity;

import java.util.Set;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.OneToMany;
import jakarta.persistence.OneToOne;
import jakarta.persistence.Table;

@Entity
@Table(name = "Package_Master")
public class Package_Master {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int pkg_id;
	private String pkg_name;

	private int catmaster_id;
	@OneToMany(cascade = CascadeType.ALL )
	@JoinColumn(name = "pkg_id")
	private Set<Booking_Header> bookingheader;

	public int getPkg_id() {
		return pkg_id;
	}

	public void setPkg_id(int pkg_id) {
		this.pkg_id = pkg_id;
	}

	public String getPkg_name() {
		return pkg_name;
	}

	public void setPkg_name(String pkg_name) {
		this.pkg_name = pkg_name;
	}

	public Set<Booking_Header> getBookingheader() {
		return bookingheader;
	}

	public void setBookingheader(Set<Booking_Header> bookingheader) {
		this.bookingheader = bookingheader;
	}

	public int getCatmaster_id() {
		return catmaster_id;
	}

	public void setCatmaster_id(int catmaster_id) {
		this.catmaster_id = catmaster_id;
	}
	
	

}
