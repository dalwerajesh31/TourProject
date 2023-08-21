package com.example.controller;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.entity.Booking_Header;
import com.example.services.Booking_HeaderManager;

@RequestMapping("/Booking_Header")
@RestController  
@CrossOrigin("*")
public class Booking_HeaderController {
	@Autowired
	Booking_HeaderManager manager;
	 @GetMapping(value = "api")
	 public List<Booking_Header> showBookings()
	 {
		  return manager.getAllBooking(); 
		
	 }
	
	 @GetMapping(value = "api/bookingById/{bid}")
	 public Optional<Booking_Header> getBooking(@PathVariable int bid)
	 {
		Optional<Booking_Header> p=manager.getBooking(bid);
		return p;
	 }
	 
	 
	
	 @DeleteMapping(value = "api/bookings/{bid}")
	 public void removebooking(@PathVariable int bid)
	 {
		manager.delete(bid);
	 }
//	 @PutMapping(value = "api/products/{pid}")
//	 public void updatepro(@RequestBody Product product,@PathVariable int pid)
//	 {
//		System.out.println("inside updatepro of controller");
//		manager.update(product,pid);
//	 }
	 @PostMapping(value = "api/products")
	 public void addbooking(@RequestBody Booking_Header booking)
	 {
		System.out.println("addpro called");
		manager.addBooking(booking);
	 }
}
