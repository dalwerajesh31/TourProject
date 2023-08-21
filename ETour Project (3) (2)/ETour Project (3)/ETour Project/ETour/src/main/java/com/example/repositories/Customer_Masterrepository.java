package com.example.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.entity.Customer_Master;

import jakarta.transaction.Transactional;
@Repository
@Transactional
public interface Customer_Masterrepository extends JpaRepository<Customer_Master,Integer> {

}