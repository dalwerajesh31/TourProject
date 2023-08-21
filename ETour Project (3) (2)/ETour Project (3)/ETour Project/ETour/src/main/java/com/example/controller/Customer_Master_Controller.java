package com.example.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.entity.Customer_Master;
import com.example.services.Customer_Master_Services;
@RequestMapping("/Customer_Master")
@RestController
@CrossOrigin("*")
public class Customer_Master_Controller {

	@Autowired
	Customer_Master_Services tservices;
	
	@PostMapping(value="api")
	public void addCustomer(@RequestBody Customer_Master t)
	{
		tservices.addCustomer(t);
	}
	
	@GetMapping(value="api/getCustomer")
	public List<Customer_Master> getCustomer()
	{
		return tservices.getCustomer();
	}
	
	@DeleteMapping(value="api/deleteCustomer/{id}")
	public void delete(@PathVariable int id)
	{
		tservices.delete(id);
	}
	
	@GetMapping(value="api/getCustomerById/{id}")
	public Optional<Customer_Master> Get(@PathVariable int id)
	{
		return tservices.getById(id);
	}
}