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
	private int booking_id;
	private Date booking_date;
	private int noofpassanger;
	private int tour_amount;
	private int taxes;
	private int total_amount;
	
	@OneToMany(cascade = CascadeType.ALL )
	@JoinColumn(name = "booking_id")
	private Set<Passanger_Master> passangermaster;	
	
	private int pkg_id;
	
	private int departure_id;

	private int cust_id;
	
	public int getPkg_id() {
		return pkg_id;
	}

	public void setPkg_id(int pkg_id) {
		this.pkg_id = pkg_id;
	}

	public int getDeparture_id() {
		return departure_id;
	}

	public void setDeparture_id(int departure_id) {
		this.departure_id = departure_id;
	}

	public int getCust_id() {
		return cust_id;
	}

	public void setCust_id(int cust_id) {
		this.cust_id = cust_id;
	}

	public int getBooking_id() {
		return booking_id;
	}

	public void setBooking_id(int booking_id) {
		this.booking_id = booking_id;
	}

	public Date getBooking_date() {
		return booking_date;
	}

	public void setBooking_date(Date booking_date) {
		this.booking_date = booking_date;
	}

	public int getNoofpassanger() {
		return noofpassanger;
	}

	public void setNoofpassanger(int noofpassanger) {
		this.noofpassanger = noofpassanger;
	}

	public int getTour_amount() {
		return tour_amount;
	}

	public void setTour_amount(int tour_amount) {
		this.tour_amount = tour_amount;
	}

	public int getTaxes() {
		return taxes;
	}

	public void setTaxes(int taxes) {
		this.taxes = taxes;
	}

	public int getTotal_amount() {
		return total_amount;
	}

	public void setTotal_amount(int total_amount) {
		this.total_amount = total_amount;
	}

	public Set<Passanger_Master> getPassangermaster() {
		return passangermaster;
	}

	public void setPassangermaster(Set<Passanger_Master> passangermaster) {
		this.passangermaster = passangermaster;
	}
	
}
