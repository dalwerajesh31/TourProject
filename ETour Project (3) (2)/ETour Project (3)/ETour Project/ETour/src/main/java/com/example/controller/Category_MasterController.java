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

import com.example.entity.Category_Master;
import com.example.services.Category_MasterManager;
@RequestMapping("/Category_Master")
@RestController  
@CrossOrigin("*")
public class Category_MasterController {
	@Autowired
	Category_MasterManager manager;
	 @GetMapping(value = "api")
	 public List<Category_Master> showBookings()
	 {
		  return manager.getAllCategory(); 
		
	 }
	
	 @GetMapping(value = "api/CategoryById/{bid}")
	 public Optional<Category_Master> getBooking(@PathVariable int bid)
	 {
		Optional<Category_Master> p=manager.getCategory(bid);
		return p;
	 }
	 
	 
	
	 @DeleteMapping(value = "api/categories/{bid}")
	 public void removecategory(@PathVariable int bid)
	 {
		manager.delete(bid);
	 }
//	 @PutMapping(value = "api/products/{pid}")
//	 public void updatepro(@RequestBody Product product,@PathVariable int pid)
//	 {
//		System.out.println("inside updatepro of controller");
//		manager.update(product,pid);
//	 }
	 @PostMapping(value = "api/category")
	 public void addbooking(@RequestBody Category_Master category)
	 {
		System.out.println("addpro called");
		manager.addCategory(category);
	 }

}