package com.example.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.entity.Cost_Master;

import jakarta.transaction.Transactional;
@Repository
@Transactional
public interface Cost_Masterrepository extends JpaRepository<Cost_Master,Integer> {

}