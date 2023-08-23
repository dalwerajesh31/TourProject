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
    private int pkgId;
    
    private String pkgName;
    
    private int catMasterId;
    
    @OneToMany(cascade = CascadeType.ALL)
    @JoinColumn(name = "pkg_id")
    private Set<Booking_Header> bookingHeaders;

	public int getPkgId() {
		return pkgId;
	}

	public void setPkgId(int pkgId) {
		this.pkgId = pkgId;
	}

	public String getPkgName() {
		return pkgName;
	}

	public void setPkgName(String pkgName) {
		this.pkgName = pkgName;
	}

	public int getCatMasterId() {
		return catMasterId;
	}

	public void setCatMasterId(int catMasterId) {
		this.catMasterId = catMasterId;
	}

	public Set<Booking_Header> getBookingHeaders() {
		return bookingHeaders;
	}

	public void setBookingHeaders(Set<Booking_Header> bookingHeaders) {
		this.bookingHeaders = bookingHeaders;
	}
	
	

}
