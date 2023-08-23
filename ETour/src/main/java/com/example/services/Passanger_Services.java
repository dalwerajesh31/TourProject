package com.example.services;
import java.util.List;
import java.util.Optional;

import com.example.entity.Passanger_Master;
import com.example.entity.Passanger_Master;

public interface Passanger_Services {
	public void addPassanger(Passanger_Master PackageMaster);
    List<Passanger_Master> getPassangerMasters();
    void delete(int departureId);
    //void update(Passanger_Master pmaster, int id);
    Optional<Passanger_Master> getById(int id);
	
	
}
