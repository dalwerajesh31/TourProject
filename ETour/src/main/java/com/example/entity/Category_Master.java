package com.example.entity;

import java.util.Set;

import org.hibernate.annotations.JdbcTypeCode;
import org.hibernate.type.SqlTypes;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.OneToMany;
import jakarta.persistence.OneToOne;
import jakarta.persistence.Table;

@Entity
@Table(name="Category_Master")
public class Category_Master {
	@Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int catMasterId;
    private String catId;
    private String subCatId;
    private String catName;
    private String catImagePath;

    @OneToMany(cascade = CascadeType.ALL)
    @JoinColumn(name = "catMasterId")
    private Set<Package_Master> packageMaster;

    @OneToMany(cascade = CascadeType.ALL)
    @JoinColumn(name = "catMasterId")
    private Set<Date_Master> dateMaster;

    @OneToMany(cascade = CascadeType.ALL)
    @JoinColumn(name = "catMasterId")
    private Set<Cost_Master> costMaster;

    @OneToMany(cascade = CascadeType.ALL)
    @JoinColumn(name = "catMasterId")
    private Set<Itinerary_Master> itineraryMaster;

	public int getCatMasterId() {
		return catMasterId;
	}

	public void setCatMasterId(int catMasterId) {
		this.catMasterId = catMasterId;
	}

	public String getCatId() {
		return catId;
	}

	public void setCatId(String catId) {
		this.catId = catId;
	}

	public String getSubCatId() {
		return subCatId;
	}

	public void setSubCatId(String subCatId) {
		this.subCatId = subCatId;
	}

	public String getCatName() {
		return catName;
	}

	public void setCatName(String catName) {
		this.catName = catName;
	}

	public String getCatImagePath() {
		return catImagePath;
	}

	public void setCatImagePath(String catImagePath) {
		this.catImagePath = catImagePath;
	}

	public Set<Package_Master> getPackageMaster() {
		return packageMaster;
	}

	public void setPackageMaster(Set<Package_Master> packageMaster) {
		this.packageMaster = packageMaster;
	}

	public Set<Date_Master> getDateMaster() {
		return dateMaster;
	}

	public void setDateMaster(Set<Date_Master> dateMaster) {
		this.dateMaster = dateMaster;
	}

	public Set<Cost_Master> getCostMaster() {
		return costMaster;
	}

	public void setCostMaster(Set<Cost_Master> costMaster) {
		this.costMaster = costMaster;
	}

	public Set<Itinerary_Master> getItineraryMaster() {
		return itineraryMaster;
	}

	public void setItineraryMaster(Set<Itinerary_Master> itineraryMaster) {
		this.itineraryMaster = itineraryMaster;
	}
		
		
}


