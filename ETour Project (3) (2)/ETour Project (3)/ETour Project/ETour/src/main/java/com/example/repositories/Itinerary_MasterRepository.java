package com.example.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.entity.Date_Master;
import com.example.entity.Itinerary_Master;

import jakarta.transaction.Transactional;
@Repository
@Transactional
public interface Itinerary_MasterRepository extends JpaRepository<Itinerary_Master, Integer>  {

}