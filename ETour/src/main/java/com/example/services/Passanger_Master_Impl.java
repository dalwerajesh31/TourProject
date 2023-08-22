package com.example.services;
import java.util.List;
import java.util.Optional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;


import com.example.entity.Passanger_Master;
import com.example.repositories.Passanger_Master_Repo;


@Service
public class Passanger_Master_Impl implements Passanger_Services{
	
	@Autowired
	Passanger_Master_Repo repo;

	
	
    @Override
	public void addPassanger(Passanger_Master PassangerMaster) {
		repo.save(PassangerMaster);
	}

	@Override
	public List<Passanger_Master> getPassangerMasters() {
		return repo.findAll();
	}

	@Override
	public void delete(int departureId) {
		repo.deleteById(departureId);
	}

	@Override
	public Optional<Passanger_Master> getById(int departureId) {
		
		return repo.findById(departureId);
	}

	@Override
	public void update(Passanger_Master pmaster, int id) {
		 repo.update(pmaster.getPax_name(),pmaster.getPax_birthdate(), pmaster.getPax_type(), pmaster.getPax_amount(), pmaster.getBooking_id(),id);
		
	}

}