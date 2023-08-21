package com.example.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.entity.Booking_Header;
import com.example.repositories.Booking_HeaderRepository;

@Service
public class Booking_HeaderManagerImpl implements Booking_HeaderManager

{   
	@Autowired
	Booking_HeaderRepository repository;

	@Override
	public void addBooking(Booking_Header booking) {
		repository.save(booking);
		
	}

	@Override
	public List<Booking_Header> getAllBooking() {
	
		return repository.findAll();
	}

	@Override
	public void delete(int id) {
		repository.deleteById(id);
	}

	//@Override
	//public void update(Booking_Header booking, int id) {
		//repository.update(booking.getBooking_Date(), booking.getDate_Master(),booking.getNoofPassenger(),booking.getPackage_Master(),booking.getTaxes(),booking.getTotal_Amount(),booking.getTour_Amount(),id);
		
	//}

	@Override
	public Optional<Booking_Header> getBooking(int id) {
	
		return repository.findById(id);
	}

}