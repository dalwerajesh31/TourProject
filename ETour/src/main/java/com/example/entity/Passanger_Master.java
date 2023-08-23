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
    private int passengerId;
    
    private String passengerName;
    
    private Date birthdate;
    
    private String passengerType;
    
    private int passengerAmount;
    
    private int bookingId;
    
    public int getPassengerId() {
        return passengerId;
    }
    
    public void setPassengerId(int passengerId) {
        this.passengerId = passengerId;
    }
    
    public String getPassengerName() {
        return passengerName;
    }
    
    public void setPassengerName(String passengerName) {
        this.passengerName = passengerName;
    }
    
    public Date getBirthdate() {
        return birthdate;
    }
    
    public void setBirthdate(Date birthdate) {
        this.birthdate = birthdate;
    }
    
    public String getPassengerType() {
        return passengerType;
    }
    
    public void setPassengerType(String passengerType) {
        this.passengerType = passengerType;
    }
    
    public int getPassengerAmount() {
        return passengerAmount;
    }
    
    public void setPassengerAmount(int passengerAmount) {
        this.passengerAmount = passengerAmount;
    }
    
    public int getBookingId() {
        return bookingId;
    }
    
    public void setBookingId(int bookingId) {
        this.bookingId = bookingId;
    }
	
}