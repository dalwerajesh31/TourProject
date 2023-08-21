package com.example.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.entity.Customer_Master;
import com.example.repositories.Customer_Masterrepository;
@Service
public class Customer_Master_Impl implements Customer_Master_Services{

	@Autowired
	Customer_Masterrepository trepository;
	
	@Override
	public void addCustomer(Customer_Master t) {
		
		trepository.save(t);
	}

	@Override
	public List<Customer_Master> getCustomer() {
		// TODO Auto-generated method stub
		return trepository.findAll();
	}

	@Override
	public void delete(int id) {
		// TODO Auto-generated method stub
		trepository.deleteById(id);
	}

	@Override
	public void update(Customer_Master customer, int id) {
		// TODO Auto-generated method stub
		
	}

	@Override
	public Optional<Customer_Master> getById(int id) {
		// TODO Auto-generated method stub
		return trepository.findById(id);
	}

}