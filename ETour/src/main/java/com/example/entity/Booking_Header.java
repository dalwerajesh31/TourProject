package com.example.entity;

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
import java.sql.Date;
import java.util.Set;
@Entity
@Table(name = "Booking_Header")
public class Booking_Header {

	@Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int bookingId;
    
    private Date bookingDate;
    private int numberOfPassengers;
    private int tourAmount;
    private int taxes;
    private int totalAmount;
    
    @OneToMany(cascade = CascadeType.ALL)
    @JoinColumn(name = "bookingId")
    private Set<Passanger_Master> passengerMaster;
    
    private int packageId;
    private int departureId;
    private int customerId;
	public int getBookingId() {
		return bookingId;
	}
	public void setBookingId(int bookingId) {
		this.bookingId = bookingId;
	}
	public Date getBookingDate() {
		return bookingDate;
	}
	public void setBookingDate(Date bookingDate) {
		this.bookingDate = bookingDate;
	}
	public int getNumberOfPassengers() {
		return numberOfPassengers;
	}
	public void setNumberOfPassengers(int numberOfPassengers) {
		this.numberOfPassengers = numberOfPassengers;
	}
	public int getTourAmount() {
		return tourAmount;
	}
	public void setTourAmount(int tourAmount) {
		this.tourAmount = tourAmount;
	}
	public int getTaxes() {
		return taxes;
	}
	public void setTaxes(int taxes) {
		this.taxes = taxes;
	}
	public int getTotalAmount() {
		return totalAmount;
	}
	public void setTotalAmount(int totalAmount) {
		this.totalAmount = totalAmount;
	}
	public Set<Passanger_Master> getPassengerMaster() {
		return passengerMaster;
	}
	public void setPassengerMaster(Set<Passanger_Master> passengerMaster) {
		this.passengerMaster = passengerMaster;
	}
	public int getPackageId() {
		return packageId;
	}
	public void setPackageId(int packageId) {
		this.packageId = packageId;
	}
	public int getDepartureId() {
		return departureId;
	}
	public void setDepartureId(int departureId) {
		this.departureId = departureId;
	}
	public int getCustomerId() {
		return customerId;
	}
	public void setCustomerId(int customerId) {
		this.customerId = customerId;
	}
	
}
