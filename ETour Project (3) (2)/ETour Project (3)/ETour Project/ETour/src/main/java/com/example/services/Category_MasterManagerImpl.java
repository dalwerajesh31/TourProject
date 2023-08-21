package com.example.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.entity.Category_Master;
import com.example.repositories.Category_MasterRepository;


@Service
public class Category_MasterManagerImpl implements Category_MasterManager {
 
	
	@Autowired
	Category_MasterRepository repository;

	@Override
	public void addCategory(Category_Master c) {
		repository.save(c);
		
	}

	@Override
	public List<Category_Master> getAllCategory() {
		return repository.findAll();
	}

	@Override
	public void delete(int id) {
		
		repository.deleteById(id);
	}

	@Override
	public Optional<Category_Master> getCategory(int id) {
	
		return repository.findById(id);
	}

	
}
