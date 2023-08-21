package com.example.services;

import java.util.List;
import java.util.Optional;

import com.example.entity.Date_Master;	

public interface Date_MasterService {
		public void addDate(Date_Master dateMaster);
	    List<Date_Master> getDateMasters();
	    void delete(int departureId);
	    //Date_Master update(Date_Master dateMaster, int departureId);
	    Optional<Date_Master> getById(int departureId);
}