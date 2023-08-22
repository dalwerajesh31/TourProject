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
@Table(name="Date_Master")
public class Date_Master {
	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
    private int departure_id;
	private Date depart_date;
	private Date end_date;
	private int no_of_days;
	private int catmaster_id;
	
	@OneToMany(cascade = CascadeType.ALL )
	@JoinColumn(name = "departure_id")
	private Set<Booking_Header> bookingheader;
	
	public int getDeparture_id() {
		return departure_id;
	}

	public void setDeparture_id(int departure_id) {
		this.departure_id = departure_id;
	}

	public Date getDepart_date() {
		return depart_date;
	}

	public void setDepart_date(Date depart_date) {
		this.depart_date = depart_date;
	}

	public Date getEnd_date() {
		return end_date;
	}

	public void setEnd_date(Date end_date) {
		this.end_date = end_date;
	}

	public int getNo_of_days() {
		return no_of_days;
	}

	public void setNo_of_days(int no_of_days) {
		this.no_of_days = no_of_days;
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
