package com.example.entity;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.OneToOne;
import jakarta.persistence.Table;

@Entity
@Table(name = "Itinerary_Master")
public class Itinerary_Master {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int itr_id;
	private int day_no;
	private String itr_dtl;
    private int catmaster_id;
	
	public int getItr_id() {
		return itr_id;
	}
	public void setItr_id(int itr_id) {
		this.itr_id = itr_id;
	}
	public int getDay_no() {
		return day_no;
	}
	public void setDay_no(int day_no) {
		this.day_no = day_no;
	}
	public String getItr_dtl() {
		return itr_dtl;
	}
	public void setItr_dtl(String itr_dtl) {
		this.itr_dtl = itr_dtl;
	}
	public int getCatmaster_id() {
		return catmaster_id;
	}
	public void setCatmaster_id(int catmaster_id) {
		this.catmaster_id = catmaster_id;
	}
	

}
