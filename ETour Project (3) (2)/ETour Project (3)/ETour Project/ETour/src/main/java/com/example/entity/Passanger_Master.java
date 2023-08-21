package com.example.entity;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;
import java.sql.Date;
@Entity
@Table(name = "Passanger_Master")
public class Passanger_Master {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int pax_id;
	private String pax_name;
	private Date pax_birthdate;
	private String pax_type;
	private int pax_amount;
	
	
	@ManyToOne(cascade = CascadeType.ALL)
	@JoinColumn(name="booking_id")
	private Booking_Header booking_header;


	public int getPax_id() {
		return pax_id;
	}


	public void setPax_id(int pax_id) {
		this.pax_id = pax_id;
	}


	public String getPax_name() {
		return pax_name;
	}


	public void setPax_name(String pax_name) {
		this.pax_name = pax_name;
	}


	public Date getPax_birthdate() {
		return pax_birthdate;
	}


	public void setPax_birthdate(Date pax_birthdate) {
		this.pax_birthdate = pax_birthdate;
	}


	public String getPax_type() {
		return pax_type;
	}


	public void setPax_type(String pax_type) {
		this.pax_type = pax_type;
	}


	public int getPax_amount() {
		return pax_amount;
	}


	public void setPax_amount(int pax_amount) {
		this.pax_amount = pax_amount;
	}


	
}
