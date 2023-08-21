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
		@GeneratedValue(strategy=GenerationType.IDENTITY)
	    private int catmaster_id;
		private String cat_id;
		private String subcat_id;
		private String cat_name;
		private String catimagepath;
	
		@OneToMany(cascade = CascadeType.ALL )
		@JoinColumn(name = "catmaster_id")
		private Set<Package_Master> packagemaster;
		
		@OneToMany(cascade = CascadeType.ALL )
		@JoinColumn(name = "catmaster_id")
		private Set<Date_Master> datemaster;
		
		@OneToMany(cascade = CascadeType.ALL )
		@JoinColumn(name = "catmaster_id")
		private Set<Cost_Master> costmaster;
		
		@OneToMany(cascade = CascadeType.ALL )
		@JoinColumn(name = "catmaster_id")
		private Set<Itinerary_Master> itinerarymaster;

		public int getCatmaster_id() {
			return catmaster_id;
		}

		public void setCatmaster_id(int catmaster_id) {
			this.catmaster_id = catmaster_id;
		}

		public String getCat_id() {
			return cat_id;
		}

		public void setCat_id(String cat_id) {
			this.cat_id = cat_id;
		}

		public String getSubcat_id() {
			return subcat_id;
		}

		public void setSubcat_id(String subcat_id) {
			this.subcat_id = subcat_id;
		}

		public String getCat_name() {
			return cat_name;
		}

		public void setCat_name(String cat_name) {
			this.cat_name = cat_name;
		}

		public String getCatimagepath() {
			return catimagepath;
		}

		public void setCatimagepath(String catimagepath) {
			this.catimagepath = catimagepath;
		}

		public Set<Package_Master> getPackagemaster() {
			return packagemaster;
		}

		public void setPackagemaster(Set<Package_Master> packagemaster) {
			this.packagemaster = packagemaster;
		}

		public Set<Date_Master> getDatemaster() {
			return datemaster;
		}

		public void setDatemaster(Set<Date_Master> datemaster) {
			this.datemaster = datemaster;
		}

		public Set<Cost_Master> getCostmaster() {
			return costmaster;
		}

		public void setCostmaster(Set<Cost_Master> costmaster) {
			this.costmaster = costmaster;
		}

		public Set<Itinerary_Master> getItinerarymaster() {
			return itinerarymaster;
		}

		public void setItinerarymaster(Set<Itinerary_Master> itinerarymaster) {
			this.itinerarymaster = itinerarymaster;
		}
		
		
	}


