package com.example.services;

import java.util.List;
import java.util.Optional;

import com.example.entity.Booking_Header;
import com.example.entity.Category_Master;

public interface Category_MasterManager {

	 void addCategory(Category_Master category);
	 List<Category_Master> getAllCategory();
	 void delete(int id);
		//void update(Booking_Header booking,int id);
		Optional<Category_Master> getCategory(int id);
}