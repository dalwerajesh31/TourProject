package com.example.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.entity.Cost_Master;
import com.example.repositories.Cost_Masterrepository;

@Service
public class Cost_Master_Impl implements Cost_Master_Services {

	
	
	
	@Autowired
	private Cost_Masterrepository trepository;
	
	
	
	public Cost_Master_Impl() {
		// TODO Auto-generated constructor stub
	}

	public Cost_Master_Impl(Cost_Masterrepository trepository) {
		this.trepository = trepository;
	}

	@Override
	public void addCost(Cost_Master t) {
		// TODO Auto-generated method stub
		trepository.save(t);
	}

	@Override
	public List<Cost_Master> getCost() {
		
		return trepository.findAll();
	}

	@Override
	public void delete(int id) {
		// TODO Auto-generated method stub
		trepository.deleteById(id);
	}


	@Override
	public Optional<Cost_Master> getById(int id) {
		// TODO Auto-generated method stub
		return trepository.findById(id);
	}

//	@Override
//	public void update(Cost_Master cost, int id) {
//		// TODO Auto-generated method stub
//		
//	}
	
}