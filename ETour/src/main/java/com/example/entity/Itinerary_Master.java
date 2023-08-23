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
    private int itineraryId;
    private int dayNumber;
    private String itineraryDetail;
    private int catMasterId;
    
    public int getItineraryId() {
        return itineraryId;
    }
    
    public void setItineraryId(int itineraryId) {
        this.itineraryId = itineraryId;
    }
    
    public int getDayNumber() {
        return dayNumber;
    }
    
    public void setDayNumber(int dayNumber) {
        this.dayNumber = dayNumber;
    }
    
    public String getItineraryDetail() {
        return itineraryDetail;
    }
    
    public void setItineraryDetail(String itineraryDetail) {
        this.itineraryDetail = itineraryDetail;
    }
    
    public int getCatMasterId() {
        return catMasterId;
    }
    
    public void setCatMasterId(int catMasterId) {
        this.catMasterId = catMasterId;
    }
}