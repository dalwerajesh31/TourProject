package com.example.entity;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.OneToOne;
import jakarta.persistence.Table;
import java.sql.Date;
@Entity
@Table(name="Cost_Master")
public class Cost_Master {
	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	private int cost_id;
	private int cost;
	private int single_prsn_cost;
	private int extra_prsn_cost;
	private int child_wth_bed;
	private int child_wto_bed;
	private Date valid_from;
	private Date valid_to;
	
	private int catmaster_id;

	public int getCost_id() {
		return cost_id;
	}

	public void setCost_id(int cost_id) {
		this.cost_id = cost_id;
	}

	public int getCost() {
		return cost;
	}

	public void setCost(int cost) {
		this.cost = cost;
	}

	public int getSingle_prsn_cost() {
		return single_prsn_cost;
	}

	public void setSingle_prsn_cost(int single_prsn_cost) {
		this.single_prsn_cost = single_prsn_cost;
	}

	public int getExtra_prsn_cost() {
		return extra_prsn_cost;
	}

	public void setExtra_prsn_cost(int extra_prsn_cost) {
		this.extra_prsn_cost = extra_prsn_cost;
	}

	public int getChild_wth_bed() {
		return child_wth_bed;
	}

	public void setChild_wth_bed(int child_wth_bed) {
		this.child_wth_bed = child_wth_bed;
	}

	public int getChild_wto_bed() {
		return child_wto_bed;
	}

	public void setChild_wto_bed(int child_wto_bed) {
		this.child_wto_bed = child_wto_bed;
	}

	public Date getValid_from() {
		return valid_from;
	}

	public void setValid_from(Date valid_from) {
		this.valid_from = valid_from;
	}

	public Date getValid_to() {
		return valid_to;
	}

	public void setValid_to(Date valid_to) {
		this.valid_to = valid_to;
	}

	public int getCatmaster_id() {
		return catmaster_id;
	}

	public void setCatmaster_id(int catmaster_id) {
		this.catmaster_id = catmaster_id;
	}
	
	
}
