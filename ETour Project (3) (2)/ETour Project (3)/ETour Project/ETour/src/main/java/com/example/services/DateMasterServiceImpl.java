package com.example.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.entity.Date_Master;
import com.example.repositories.Date_MasterRepository;

@Service
public class DateMasterServiceImpl implements Date_MasterService{
	
	@Autowired
	Date_MasterRepository repo;
	@Override
	public void addDate(Date_Master dateMaster) {
		repo.save(dateMaster);
	}

	@Override
	public List<Date_Master> getDateMasters() {
		return repo.findAll();
	}

	@Override
	public void delete(int departureId) {
		repo.deleteById(departureId);
	}

	@Override
	public Optional<Date_Master> getById(int departureId) {
		
		return repo.findById(departureId);
	}

}